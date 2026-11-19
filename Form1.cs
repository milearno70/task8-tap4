using System.Data;
using Microsoft.Data.SqlClient;

namespace AdoNetTasks;

public partial class Form1 : Form
{
    bool loading = false;

    public Form1()
    {
        InitializeComponent();
    }

    void Form1_Load(object sender, EventArgs e)
    {
        LoadAuthors();
        LoadMembers();
        LoadBooks();
        LoadLoans();
    }

    void txtYear_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            e.Handled = true;
    }


    void LoadAuthors()
    {
        try
        {
            using (var con = new SqlConnection(Db.ConnStr))
            {
                var dt = new DataTable();
                var da = new SqlDataAdapter("SELECT Id, FullName FROM Authors ORDER BY FullName", con);
                da.Fill(dt);
                cbAuthor.ValueMember = "Id";
                cbAuthor.DisplayMember = "FullName";
                cbAuthor.DataSource = dt;
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Verilənlər bazası xətası: " + ex.Message);
        }
    }

    void LoadMembers()
    {
        try
        {
            using (var con = new SqlConnection(Db.ConnStr))
            {
                var dt = new DataTable();
                var da = new SqlDataAdapter("SELECT Id, FullName FROM Members ORDER BY FullName", con);
                da.Fill(dt);
                cbMember.ValueMember = "Id";
                cbMember.DisplayMember = "FullName";
                cbMember.DataSource = dt;
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Verilənlər bazası xətası: " + ex.Message);
        }
    }

    void LoadBooks()
    {
        try
        {
            loading = true;
            using (var con = new SqlConnection(Db.ConnStr))
            {
                string sql =
                    @"SELECT b.Id, b.AuthorId, b.Title, a.FullName AS Author, b.PublishYear
                      FROM Books b
                      INNER JOIN Authors a ON a.Id = b.AuthorId
                      ORDER BY b.Title";
                var dt = new DataTable();
                var da = new SqlDataAdapter(sql, con);
                da.Fill(dt);

                dgvBooks.DataSource = dt;
                dgvBooks.Columns["Id"].Visible = false;
                dgvBooks.Columns["AuthorId"].Visible = false;

                cbBook.ValueMember = "Id";
                cbBook.DisplayMember = "Title";
                cbBook.DataSource = dt.Copy();
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Verilənlər bazası xətası: " + ex.Message);
        }
        finally
        {
            loading = false;
        }
    }

    void LoadLoans()
    {
        try
        {
            using (var con = new SqlConnection(Db.ConnStr))
            {
                string sql =
                    @"SELECT l.Id, b.Title AS Book, m.FullName AS Member, l.LoanDate
                      FROM Loans l
                      INNER JOIN Books b ON b.Id = l.BookId
                      INNER JOIN Members m ON m.Id = l.MemberId
                      WHERE l.ReturnDate IS NULL
                      ORDER BY l.LoanDate";
                var dt = new DataTable();
                var da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
                dgvLoans.DataSource = dt;
                dgvLoans.Columns["Id"].Visible = false;
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Verilənlər bazası xətası: " + ex.Message);
        }
    }

    void dgvBooks_SelectionChanged(object sender, EventArgs e)
    {
        if (loading || dgvBooks.CurrentRow == null) return;

        txtTitle.Text = dgvBooks.CurrentRow.Cells["Title"].Value.ToString();
        txtYear.Text = dgvBooks.CurrentRow.Cells["PublishYear"].Value.ToString();
        cbAuthor.SelectedValue = dgvBooks.CurrentRow.Cells["AuthorId"].Value;
    }


    bool ReadBook(out string title, out int authorId, out int year)
    {
        title = txtTitle.Text.Trim();
        authorId = 0;
        year = 0;

        if (title == "")
        {
            MessageBox.Show("Kitabın adını yazın.");
            return false;
        }
        if (cbAuthor.SelectedValue == null)
        {
            MessageBox.Show("Müəllif seçin.");
            return false;
        }
        if (!int.TryParse(txtYear.Text, out year) || year < 1 || year > DateTime.Now.Year)
        {
            MessageBox.Show("İl düzgün deyil.");
            return false;
        }
        authorId = Convert.ToInt32(cbAuthor.SelectedValue);
        return true;
    }

    void btnAddBook_Click(object sender, EventArgs e)
    {
        string title;
        int authorId, year;
        if (!ReadBook(out title, out authorId, out year)) return;

        try
        {
            using (var con = new SqlConnection(Db.ConnStr))
            {
                var cmd = new SqlCommand(
                    "INSERT INTO Books (Title, AuthorId, PublishYear) VALUES (@t, @a, @y)", con);
                cmd.Parameters.AddWithValue("@t", title);
                cmd.Parameters.AddWithValue("@a", authorId);
                cmd.Parameters.AddWithValue("@y", year);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            LoadBooks();
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Verilənlər bazası xətası: " + ex.Message);
        }
    }

    void btnUpdateBook_Click(object sender, EventArgs e)
    {
        if (dgvBooks.CurrentRow == null)
        {
            MessageBox.Show("Düzəltmək üçün kitab seçin.");
            return;
        }

        string title;
        int authorId, year;
        if (!ReadBook(out title, out authorId, out year)) return;
        int id = Convert.ToInt32(dgvBooks.CurrentRow.Cells["Id"].Value);

        try
        {
            using (var con = new SqlConnection(Db.ConnStr))
            {
                var cmd = new SqlCommand(
                    "UPDATE Books SET Title = @t, AuthorId = @a, PublishYear = @y WHERE Id = @id", con);
                cmd.Parameters.AddWithValue("@t", title);
                cmd.Parameters.AddWithValue("@a", authorId);
                cmd.Parameters.AddWithValue("@y", year);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            LoadBooks();
            LoadLoans();
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Verilənlər bazası xətası: " + ex.Message);
        }
    }

    void btnDeleteBook_Click(object sender, EventArgs e)
    {
        if (dgvBooks.CurrentRow == null)
        {
            MessageBox.Show("Silmək üçün kitab seçin.");
            return;
        }

        if (MessageBox.Show("Seçilmiş kitab silinsin?", "Təsdiq", MessageBoxButtons.YesNo) != DialogResult.Yes)
            return;

        int id = Convert.ToInt32(dgvBooks.CurrentRow.Cells["Id"].Value);

        try
        {
            using (var con = new SqlConnection(Db.ConnStr))
            {
                var cmd = new SqlCommand("DELETE FROM Books WHERE Id = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            LoadBooks();
        }
        catch (SqlException ex) when (ex.Number == 547)
        {
            MessageBox.Show("Bu kitabı silmək olmaz: onun icarə tarixçəsi var.");
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Verilənlər bazası xətası: " + ex.Message);
        }
    }

    // ----------- İcarəyə ver / Qaytar -----------

    void btnLend_Click(object sender, EventArgs e)
    {
        if (cbBook.SelectedValue == null || cbMember.SelectedValue == null)
        {
            MessageBox.Show("Kitab və üzv seçin.");
            return;
        }

        int bookId = Convert.ToInt32(cbBook.SelectedValue);
        int memberId = Convert.ToInt32(cbMember.SelectedValue);

        try
        {
            using (var con = new SqlConnection(Db.ConnStr))
            {
                con.Open();

                var check = new SqlCommand(
                    "SELECT COUNT(*) FROM Loans WHERE BookId = @b AND ReturnDate IS NULL", con);
                check.Parameters.AddWithValue("@b", bookId);
                int active = Convert.ToInt32(check.ExecuteScalar());
                if (active > 0)
                {
                    MessageBox.Show("Bu kitab artıq icarədədir.");
                    return;
                }

                var cmd = new SqlCommand(
                    "INSERT INTO Loans (BookId, MemberId, LoanDate) VALUES (@b, @m, GETDATE())", con);
                cmd.Parameters.AddWithValue("@b", bookId);
                cmd.Parameters.AddWithValue("@m", memberId);
                cmd.ExecuteNonQuery();
            }
            LoadLoans();
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Verilənlər bazası xətası: " + ex.Message);
        }
    }

    void btnReturn_Click(object sender, EventArgs e)
    {
        if (dgvLoans.CurrentRow == null)
        {
            MessageBox.Show("Qaytarmaq üçün siyahıdan icarə seçin.");
            return;
        }

        int loanId = Convert.ToInt32(dgvLoans.CurrentRow.Cells["Id"].Value);

        try
        {
            using (var con = new SqlConnection(Db.ConnStr))
            {
                var cmd = new SqlCommand(
                    "UPDATE Loans SET ReturnDate = GETDATE() WHERE Id = @id AND ReturnDate IS NULL", con);
                cmd.Parameters.AddWithValue("@id", loanId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            LoadLoans();
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Verilənlər bazası xətası: " + ex.Message);
        }
    }
}
