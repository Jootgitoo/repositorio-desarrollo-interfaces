using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Mysqlx.Crud;
using proyectoExamen.domain;
using proyectoExamen.reports;

namespace proyectoExamen
{

    //insert into bbddclublectura.gender values(1, "Terror");
    //insert into bbddclublectura.gender values(2, "Accion");



    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
  {

        /// <summary>
        /// The list member
        /// </summary>
        List<Member> listMember;
        /// <summary>
        /// The list books
        /// </summary>
        List<Book> listBooks;
        /// <summary>
        /// The list loan
        /// </summary>
        List<Loan> listLoan;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
          InitializeComponent();

            listMember = new List<Member>();
            listBooks = new List<Book>();

            Member member = new Member();
            listMember = member.genListaMembers();
            dgMembers.ItemsSource = listMember;


            Book book = new Book();
            listBooks = book.genListaBooks();
            dgBook.ItemsSource = listBooks;


            Loan loan = new Loan();
            listLoan = loan.genListaLoans();
            dgLoan.ItemsSource = listLoan;
        }

        /// <summary>
        /// Handles the Click event of the btnInsertMember control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnInsertMember_Click(object sender, RoutedEventArgs e)
        {
            Member member = new Member(tbNameMember.Text, Convert.ToDateTime(tbBirthMember.Text), tbEmailMember.Text, Convert.ToInt32(tbTelephoneMember.Text) );
            
            member.insertMember();

            listMember.Add(member);

            dgMembers.Items.Refresh();

        }

        /// <summary>
        /// Handles the Click event of the btnInsertBook control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnInsertBook_Click(object sender, RoutedEventArgs e)
        {
            Book book = new Book(tbTitleBook.Text, tbAuthorBook.Text, Convert.ToDateTime(tbPublication.Text), Convert.ToInt32(tbIdGenere.Text) );

            book.insertBook();

            listBooks.Add(book);

            dgBook.Items.Refresh();
        }

        /// <summary>
        /// Handles the Click event of the btnInsertLoan control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnInsertLoan_Click(object sender, RoutedEventArgs e)
        {
            Loan loan = new Loan(Convert.ToDateTime(tbLoanDate.Text), Convert.ToDateTime(tbReturnDate.Text), Convert.ToInt32(tbIdMemberLoan.Text), Convert.ToInt32(tbIdBookLoan.Text));
            
            loan.insertLoan();

            listLoan.Add(loan);

            dgLoan.Items.Refresh();
        }

        /// <summary>
        /// Handles the Click event of the btnDeleteMember control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnDeleteMember_Click(object sender, RoutedEventArgs e)
        {
            Member m = (Member)dgMembers.SelectedItem;
            m.deleteMember();

            List<Member> newList = (List<Member>)dgMembers.ItemsSource;
            newList.Remove(m);

            dgMembers.Items.Refresh();
            dgMembers.ItemsSource = newList;
        }

        /// <summary>
        /// Handles the Click event of the btnDeleteBook control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnDeleteBook_Click(object sender, RoutedEventArgs e)
        {
            Book b = (Book)dgBook.SelectedItem;
            b.deleteBook();

            List<Book> newList = (List<Book>)dgBook.ItemsSource;
            newList.Remove(b);

            dgBook.Items.Refresh();
            dgBook.ItemsSource = newList;
        }

        /// <summary>
        /// Handles the Click event of the btnModifyMember control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnModifyMember_Click(object sender, RoutedEventArgs e)
        {
            Member m = (Member)dgMembers.SelectedItem;
            List<Member> newList = (List<Member>)dgMembers.ItemsSource;
            newList.Remove(m);

            Member member = new Member(tbNameMember.Text, Convert.ToDateTime(tbBirthMember.Text), tbEmailMember.Text, Convert.ToInt32(tbTelephoneMember.Text));
            member.IdMember = m.IdMember;

            newList.Add(member);
            member.modifyMember();

            dgMembers.Items.Refresh();
            dgMembers.ItemsSource = newList;

        }

        /// <summary>
        /// Handles the Click event of the btnModifyBook control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnModifyBook_Click(object sender, RoutedEventArgs e)
        {
            Book b = (Book)dgBook.SelectedItem;
            List<Book> newList = (List<Book>)dgBook.ItemsSource;
            newList.Remove(b);

            Book book = new Book(tbTitleBook.Text, tbAuthorBook.Text, Convert.ToDateTime(tbPublication.Text), Convert.ToInt32(tbIdGenere.Text));
            book.IdBook = b.IdBook;

            newList.Add(book);
            book.modifyBook();

            dgBook.Items.Refresh();
            dgBook.ItemsSource = newList;

        }

        /// <summary>
        /// Handles the Click event of the btnCargarReporte1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnCargarReporte1_Click(object sender, RoutedEventArgs e)
        {
            DataTable tablaBook = new DataTable("Book");

            tablaBook.Columns.Add("titleBook");
            tablaBook.Columns.Add("authorBook");
            tablaBook.Columns.Add("publicationYearBook");

            foreach(Book b in listBooks)
            {
                DataRow row = tablaBook.NewRow();
                row["titleBook"] = b.TitleBook;
                row["authorBook"] = b.AuthorBook;
                row["publicationYearBook"] = b.PublicationYearBook;
                tablaBook.Rows.Add(row);
            }

            reporte_libros reporteLibros = new reporte_libros();
            reporteLibros.Database.Tables["Book"].SetDataSource(tablaBook);

            reportBook.ViewerCore.ReportSource = reporteLibros;
        }

        /// <summary>
        /// Handles the Click event of the btnCargarReporteLoan control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnCargarReporteLoan_Click(object sender, RoutedEventArgs e)
        {
            DataTable tablaLoan = new DataTable("Loan");

            tablaLoan.Columns.Add("loanDate");
            tablaLoan.Columns.Add("returnDate");
            tablaLoan.Columns.Add("idBook");

            foreach(Loan l in listLoan)
            {
                DataRow row = tablaLoan.NewRow();
                row["loanDate"] = l.LoanDate;
                row["returnDate"] = l.ReturnDate;
                row["idBook"] = l.IdBook;
                tablaLoan.Rows.Add(row);
            }

            Reporte_loan rl = new Reporte_loan();
            rl.Database.Tables["Loan"].SetDataSource(tablaLoan);

            reportLoan.ViewerCore.ReportSource = rl;
        }
    }
}
