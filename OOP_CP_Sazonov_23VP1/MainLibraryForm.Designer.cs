namespace OOP_CP_Sazonov_23VP1
{
    partial class MainLibraryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLibraryForm));
            addBookToDataBaseToolStrip = new ToolStrip();
            booksDropBoxToolStrip = new ToolStripDropDownButton();
            addBookToolStripMenuItem = new ToolStripMenuItem();
            removeBookToolStripMenuItem = new ToolStripMenuItem();
            giveOutBookToolStripMenuItem = new ToolStripMenuItem();
            editBookInfoToolStripMenuItem = new ToolStripMenuItem();
            clientsToolStripDropDownButton = new ToolStripDropDownButton();
            addReadersToolStripMenuItem = new ToolStripMenuItem();
            removeReaderToolStripMenuItem = new ToolStripMenuItem();
            вернутьКнигуToolStripMenuItem = new ToolStripMenuItem();
            editReaderDataToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripDropDownButton = new ToolStripDropDownButton();
            debtorReportToolStripMenuItem = new ToolStripMenuItem();
            readerReportToolStripMenuItem = new ToolStripMenuItem();
            bookReportToolStripMenuItem = new ToolStripMenuItem();
            booksReviewDataGridView = new DataGridView();
            bookId = new DataGridViewTextBoxColumn();
            bookName = new DataGridViewTextBoxColumn();
            yearOfPublishing = new DataGridViewTextBoxColumn();
            bookAuthors = new DataGridViewTextBoxColumn();
            bookGenres = new DataGridViewTextBoxColumn();
            publisherName = new DataGridViewTextBoxColumn();
            bookISBN = new DataGridViewTextBoxColumn();
            readerID = new DataGridViewTextBoxColumn();
            returnDate = new DataGridViewTextBoxColumn();
            booksReviewPanel = new Panel();
            doSelectQueryPanel = new Panel();
            resetQuery = new Button();
            ascendingDescendingPanel = new Panel();
            descendingOrder = new RadioButton();
            ascendingOrder = new RadioButton();
            orderByPanel = new Panel();
            orderByGenre = new RadioButton();
            orderByAuthor = new RadioButton();
            orderByIsbn = new RadioButton();
            orderByPublisher = new RadioButton();
            orderByDateButton = new RadioButton();
            orderByName = new RadioButton();
            panel2 = new Panel();
            genreComboBox = new ComboBox();
            genreLabel = new Label();
            authorNamePanel = new Panel();
            authorNameComboBox = new ComboBox();
            authorNameLabel = new Label();
            isbnPanel = new Panel();
            isbnValueTextBox = new TextBox();
            isbnValueLabel = new Label();
            bookPublisherPanel = new Panel();
            bookPublisherNameTextBox = new TextBox();
            publisherNameLabel = new Label();
            bookPublishingDatePanel = new Panel();
            bookPublishingDateNumericUpDown = new NumericUpDown();
            bookPublishingDateLabel = new Label();
            selectBookNamePanel = new Panel();
            bookNameSelectTextBox = new TextBox();
            bookNameSelectLabel = new Label();
            findAndSortBooksLabel = new Label();
            findBookButton = new Button();
            mainWindowTabs = new TabControl();
            booksPage = new TabPage();
            findAndSortClients = new TabPage();
            findAndSortReadersPanel = new Panel();
            buttonsPanel = new Panel();
            resetButton = new Button();
            findReadersButton = new Button();
            ascDescOrderPanel = new Panel();
            descendingReaderOrder = new RadioButton();
            ascendingReaderOrder = new RadioButton();
            fieldOrderPanel = new Panel();
            orderByDebtor = new RadioButton();
            orderByAddress = new RadioButton();
            orderByPhone = new RadioButton();
            orderByReaderName = new RadioButton();
            selectReaderSettingsPanel = new Panel();
            isDebtorPanel = new Panel();
            isDebtorComboBox = new ComboBox();
            isDebtorLabel = new Label();
            readerAddressPanel = new Panel();
            readerAddressTextBox = new TextBox();
            readerAddressLabel = new Label();
            readerPhoneTextBox = new Panel();
            textBox2 = new TextBox();
            phoneNumberLabel = new Label();
            readerNamePanel = new Panel();
            readerNameTextBox = new TextBox();
            readerNameLabel = new Label();
            findAndSortReadersLabel = new Label();
            readersPreviewDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            readerName = new DataGridViewTextBoxColumn();
            phoneNumber = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            isDebtor = new DataGridViewTextBoxColumn();
            addBookToDataBaseToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)booksReviewDataGridView).BeginInit();
            booksReviewPanel.SuspendLayout();
            doSelectQueryPanel.SuspendLayout();
            ascendingDescendingPanel.SuspendLayout();
            orderByPanel.SuspendLayout();
            panel2.SuspendLayout();
            authorNamePanel.SuspendLayout();
            isbnPanel.SuspendLayout();
            bookPublisherPanel.SuspendLayout();
            bookPublishingDatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookPublishingDateNumericUpDown).BeginInit();
            selectBookNamePanel.SuspendLayout();
            mainWindowTabs.SuspendLayout();
            booksPage.SuspendLayout();
            findAndSortClients.SuspendLayout();
            findAndSortReadersPanel.SuspendLayout();
            buttonsPanel.SuspendLayout();
            ascDescOrderPanel.SuspendLayout();
            fieldOrderPanel.SuspendLayout();
            selectReaderSettingsPanel.SuspendLayout();
            isDebtorPanel.SuspendLayout();
            readerAddressPanel.SuspendLayout();
            readerPhoneTextBox.SuspendLayout();
            readerNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)readersPreviewDataGridView).BeginInit();
            SuspendLayout();
            // 
            // addBookToDataBaseToolStrip
            // 
            addBookToDataBaseToolStrip.ImageScalingSize = new Size(24, 24);
            addBookToDataBaseToolStrip.Items.AddRange(new ToolStripItem[] { booksDropBoxToolStrip, clientsToolStripDropDownButton, reportToolStripDropDownButton });
            addBookToDataBaseToolStrip.Location = new Point(0, 0);
            addBookToDataBaseToolStrip.Name = "addBookToDataBaseToolStrip";
            addBookToDataBaseToolStrip.Size = new Size(1320, 34);
            addBookToDataBaseToolStrip.TabIndex = 0;
            addBookToDataBaseToolStrip.Text = "Добавить книгу";
            // 
            // booksDropBoxToolStrip
            // 
            booksDropBoxToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Text;
            booksDropBoxToolStrip.DropDownItems.AddRange(new ToolStripItem[] { addBookToolStripMenuItem, removeBookToolStripMenuItem, giveOutBookToolStripMenuItem, editBookInfoToolStripMenuItem });
            booksDropBoxToolStrip.Image = (Image)resources.GetObject("booksDropBoxToolStrip.Image");
            booksDropBoxToolStrip.ImageTransparentColor = Color.Magenta;
            booksDropBoxToolStrip.Name = "booksDropBoxToolStrip";
            booksDropBoxToolStrip.Size = new Size(77, 29);
            booksDropBoxToolStrip.Text = "Книги";
            booksDropBoxToolStrip.ToolTipText = " Книги";
            // 
            // addBookToolStripMenuItem
            // 
            addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            addBookToolStripMenuItem.Size = new Size(379, 34);
            addBookToolStripMenuItem.Text = "Добавить книгу...";
            addBookToolStripMenuItem.Click += addBookToolStripMenuItem_Click;
            // 
            // removeBookToolStripMenuItem
            // 
            removeBookToolStripMenuItem.Name = "removeBookToolStripMenuItem";
            removeBookToolStripMenuItem.Size = new Size(379, 34);
            removeBookToolStripMenuItem.Text = "Удалить книгу...";
            removeBookToolStripMenuItem.Click += removeBookToolStripMenuItem_Click;
            // 
            // giveOutBookToolStripMenuItem
            // 
            giveOutBookToolStripMenuItem.Name = "giveOutBookToolStripMenuItem";
            giveOutBookToolStripMenuItem.Size = new Size(379, 34);
            giveOutBookToolStripMenuItem.Text = "Выдать книгу...";
            giveOutBookToolStripMenuItem.Click += giveOutBookToolStripMenuItem_Click;
            // 
            // editBookInfoToolStripMenuItem
            // 
            editBookInfoToolStripMenuItem.Name = "editBookInfoToolStripMenuItem";
            editBookInfoToolStripMenuItem.Size = new Size(379, 34);
            editBookInfoToolStripMenuItem.Text = "Редактировать данные о книге...";
            editBookInfoToolStripMenuItem.Click += editBookInfoToolStripMenuItem_Click;
            // 
            // clientsToolStripDropDownButton
            // 
            clientsToolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            clientsToolStripDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { addReadersToolStripMenuItem, removeReaderToolStripMenuItem, вернутьКнигуToolStripMenuItem, editReaderDataToolStripMenuItem });
            clientsToolStripDropDownButton.Image = (Image)resources.GetObject("clientsToolStripDropDownButton.Image");
            clientsToolStripDropDownButton.ImageTransparentColor = Color.Magenta;
            clientsToolStripDropDownButton.Name = "clientsToolStripDropDownButton";
            clientsToolStripDropDownButton.Size = new Size(103, 29);
            clientsToolStripDropDownButton.Text = "Читатели";
            clientsToolStripDropDownButton.ToolTipText = " Читатели";
            // 
            // addReadersToolStripMenuItem
            // 
            addReadersToolStripMenuItem.Name = "addReadersToolStripMenuItem";
            addReadersToolStripMenuItem.Size = new Size(404, 34);
            addReadersToolStripMenuItem.Text = "Добавить читателя...";
            addReadersToolStripMenuItem.Click += addReadersToolStripMenuItem_Click;
            // 
            // removeReaderToolStripMenuItem
            // 
            removeReaderToolStripMenuItem.Name = "removeReaderToolStripMenuItem";
            removeReaderToolStripMenuItem.Size = new Size(404, 34);
            removeReaderToolStripMenuItem.Text = "Удалить читателя...";
            removeReaderToolStripMenuItem.Click += removeReaderToolStripMenuItem_Click;
            // 
            // вернутьКнигуToolStripMenuItem
            // 
            вернутьКнигуToolStripMenuItem.Name = "вернутьКнигуToolStripMenuItem";
            вернутьКнигуToolStripMenuItem.Size = new Size(404, 34);
            вернутьКнигуToolStripMenuItem.Text = "Вернуть книгу...";
            вернутьКнигуToolStripMenuItem.Click += returnBookToolStripMenuItem_Click;
            // 
            // editReaderDataToolStripMenuItem
            // 
            editReaderDataToolStripMenuItem.Name = "editReaderDataToolStripMenuItem";
            editReaderDataToolStripMenuItem.Size = new Size(404, 34);
            editReaderDataToolStripMenuItem.Text = "Редактировать данные о читателе...";
            editReaderDataToolStripMenuItem.Click += editReaderDataToolStripMenuItem_Click;
            // 
            // reportToolStripDropDownButton
            // 
            reportToolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            reportToolStripDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { debtorReportToolStripMenuItem, readerReportToolStripMenuItem, bookReportToolStripMenuItem });
            reportToolStripDropDownButton.Image = (Image)resources.GetObject("reportToolStripDropDownButton.Image");
            reportToolStripDropDownButton.ImageTransparentColor = Color.Magenta;
            reportToolStripDropDownButton.Name = "reportToolStripDropDownButton";
            reportToolStripDropDownButton.Size = new Size(90, 29);
            reportToolStripDropDownButton.Text = "Отчёты";
            // 
            // debtorReportToolStripMenuItem
            // 
            debtorReportToolStripMenuItem.Name = "debtorReportToolStripMenuItem";
            debtorReportToolStripMenuItem.Size = new Size(271, 34);
            debtorReportToolStripMenuItem.Text = "Отчёт о должниках";
            // 
            // readerReportToolStripMenuItem
            // 
            readerReportToolStripMenuItem.Name = "readerReportToolStripMenuItem";
            readerReportToolStripMenuItem.Size = new Size(271, 34);
            readerReportToolStripMenuItem.Text = "Отчёт о читателях";
            // 
            // bookReportToolStripMenuItem
            // 
            bookReportToolStripMenuItem.Name = "bookReportToolStripMenuItem";
            bookReportToolStripMenuItem.Size = new Size(271, 34);
            bookReportToolStripMenuItem.Text = "Отчёт о книгах";
            // 
            // booksReviewDataGridView
            // 
            booksReviewDataGridView.AllowUserToAddRows = false;
            booksReviewDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            booksReviewDataGridView.BackgroundColor = Color.PapayaWhip;
            booksReviewDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksReviewDataGridView.Columns.AddRange(new DataGridViewColumn[] { bookId, bookName, yearOfPublishing, bookAuthors, bookGenres, publisherName, bookISBN, readerID, returnDate });
            booksReviewDataGridView.Dock = DockStyle.Left;
            booksReviewDataGridView.Location = new Point(10, 0);
            booksReviewDataGridView.Name = "booksReviewDataGridView";
            booksReviewDataGridView.ReadOnly = true;
            booksReviewDataGridView.RowHeadersVisible = false;
            booksReviewDataGridView.RowHeadersWidth = 62;
            booksReviewDataGridView.Size = new Size(926, 685);
            booksReviewDataGridView.TabIndex = 1;
            // 
            // bookId
            // 
            bookId.FillWeight = 15.794117F;
            bookId.HeaderText = "ID";
            bookId.MinimumWidth = 8;
            bookId.Name = "bookId";
            bookId.ReadOnly = true;
            // 
            // bookName
            // 
            bookName.FillWeight = 30.3281269F;
            bookName.HeaderText = "Название";
            bookName.MinimumWidth = 8;
            bookName.Name = "bookName";
            bookName.ReadOnly = true;
            // 
            // yearOfPublishing
            // 
            yearOfPublishing.FillWeight = 24.1615372F;
            yearOfPublishing.HeaderText = "Дата выхода";
            yearOfPublishing.MinimumWidth = 8;
            yearOfPublishing.Name = "yearOfPublishing";
            yearOfPublishing.ReadOnly = true;
            // 
            // bookAuthors
            // 
            bookAuthors.FillWeight = 25F;
            bookAuthors.HeaderText = "Авторы";
            bookAuthors.MinimumWidth = 8;
            bookAuthors.Name = "bookAuthors";
            bookAuthors.ReadOnly = true;
            // 
            // bookGenres
            // 
            bookGenres.FillWeight = 25F;
            bookGenres.HeaderText = "Жанры";
            bookGenres.MinimumWidth = 8;
            bookGenres.Name = "bookGenres";
            bookGenres.ReadOnly = true;
            // 
            // publisherName
            // 
            publisherName.FillWeight = 35.4135742F;
            publisherName.HeaderText = "Издательство";
            publisherName.MinimumWidth = 8;
            publisherName.Name = "publisherName";
            publisherName.ReadOnly = true;
            // 
            // bookISBN
            // 
            bookISBN.FillWeight = 19.5845146F;
            bookISBN.HeaderText = "ISBN";
            bookISBN.MinimumWidth = 8;
            bookISBN.Name = "bookISBN";
            bookISBN.ReadOnly = true;
            // 
            // readerID
            // 
            readerID.FillWeight = 20F;
            readerID.HeaderText = "ID читателя";
            readerID.MinimumWidth = 8;
            readerID.Name = "readerID";
            readerID.ReadOnly = true;
            // 
            // returnDate
            // 
            returnDate.FillWeight = 30F;
            returnDate.HeaderText = "Возврат до";
            returnDate.MinimumWidth = 8;
            returnDate.Name = "returnDate";
            returnDate.ReadOnly = true;
            // 
            // booksReviewPanel
            // 
            booksReviewPanel.Controls.Add(doSelectQueryPanel);
            booksReviewPanel.Controls.Add(booksReviewDataGridView);
            booksReviewPanel.Dock = DockStyle.Fill;
            booksReviewPanel.Location = new Point(3, 3);
            booksReviewPanel.Margin = new Padding(30, 3, 3, 3);
            booksReviewPanel.Name = "booksReviewPanel";
            booksReviewPanel.Padding = new Padding(10, 0, 0, 0);
            booksReviewPanel.Size = new Size(1306, 685);
            booksReviewPanel.TabIndex = 2;
            // 
            // doSelectQueryPanel
            // 
            doSelectQueryPanel.Controls.Add(resetQuery);
            doSelectQueryPanel.Controls.Add(ascendingDescendingPanel);
            doSelectQueryPanel.Controls.Add(orderByPanel);
            doSelectQueryPanel.Controls.Add(panel2);
            doSelectQueryPanel.Controls.Add(authorNamePanel);
            doSelectQueryPanel.Controls.Add(isbnPanel);
            doSelectQueryPanel.Controls.Add(bookPublisherPanel);
            doSelectQueryPanel.Controls.Add(bookPublishingDatePanel);
            doSelectQueryPanel.Controls.Add(selectBookNamePanel);
            doSelectQueryPanel.Controls.Add(findAndSortBooksLabel);
            doSelectQueryPanel.Controls.Add(findBookButton);
            doSelectQueryPanel.Dock = DockStyle.Fill;
            doSelectQueryPanel.Location = new Point(936, 0);
            doSelectQueryPanel.Name = "doSelectQueryPanel";
            doSelectQueryPanel.Size = new Size(370, 685);
            doSelectQueryPanel.TabIndex = 2;
            // 
            // resetQuery
            // 
            resetQuery.BackColor = Color.WhiteSmoke;
            resetQuery.Cursor = Cursors.Hand;
            resetQuery.Dock = DockStyle.Bottom;
            resetQuery.Location = new Point(0, 617);
            resetQuery.Name = "resetQuery";
            resetQuery.Size = new Size(370, 34);
            resetQuery.TabIndex = 10;
            resetQuery.Text = "Сбросить параметры";
            resetQuery.UseVisualStyleBackColor = false;
            // 
            // ascendingDescendingPanel
            // 
            ascendingDescendingPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ascendingDescendingPanel.Controls.Add(descendingOrder);
            ascendingDescendingPanel.Controls.Add(ascendingOrder);
            ascendingDescendingPanel.Location = new Point(0, 509);
            ascendingDescendingPanel.Name = "ascendingDescendingPanel";
            ascendingDescendingPanel.Size = new Size(370, 43);
            ascendingDescendingPanel.TabIndex = 9;
            // 
            // descendingOrder
            // 
            descendingOrder.AutoSize = true;
            descendingOrder.Location = new Point(189, 3);
            descendingOrder.Name = "descendingOrder";
            descendingOrder.Size = new Size(152, 29);
            descendingOrder.TabIndex = 1;
            descendingOrder.TabStop = true;
            descendingOrder.Text = "По убыванию";
            descendingOrder.UseVisualStyleBackColor = true;
            // 
            // ascendingOrder
            // 
            ascendingOrder.AutoSize = true;
            ascendingOrder.Location = new Point(9, 3);
            ascendingOrder.Name = "ascendingOrder";
            ascendingOrder.Size = new Size(174, 29);
            ascendingOrder.TabIndex = 0;
            ascendingOrder.Text = "По возрастанию";
            ascendingOrder.UseVisualStyleBackColor = true;
            // 
            // orderByPanel
            // 
            orderByPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            orderByPanel.Controls.Add(orderByGenre);
            orderByPanel.Controls.Add(orderByAuthor);
            orderByPanel.Controls.Add(orderByIsbn);
            orderByPanel.Controls.Add(orderByPublisher);
            orderByPanel.Controls.Add(orderByDateButton);
            orderByPanel.Controls.Add(orderByName);
            orderByPanel.Location = new Point(0, 390);
            orderByPanel.Name = "orderByPanel";
            orderByPanel.Size = new Size(370, 119);
            orderByPanel.TabIndex = 8;
            // 
            // orderByGenre
            // 
            orderByGenre.AutoSize = true;
            orderByGenre.Location = new Point(189, 76);
            orderByGenre.Name = "orderByGenre";
            orderByGenre.Size = new Size(118, 29);
            orderByGenre.TabIndex = 5;
            orderByGenre.TabStop = true;
            orderByGenre.Text = "По жанру";
            orderByGenre.UseVisualStyleBackColor = true;
            // 
            // orderByAuthor
            // 
            orderByAuthor.AutoSize = true;
            orderByAuthor.Location = new Point(9, 76);
            orderByAuthor.Name = "orderByAuthor";
            orderByAuthor.Size = new Size(123, 29);
            orderByAuthor.TabIndex = 4;
            orderByAuthor.TabStop = true;
            orderByAuthor.Text = "По автору";
            orderByAuthor.UseVisualStyleBackColor = true;
            // 
            // orderByIsbn
            // 
            orderByIsbn.AutoSize = true;
            orderByIsbn.Location = new Point(189, 41);
            orderByIsbn.Name = "orderByIsbn";
            orderByIsbn.Size = new Size(104, 29);
            orderByIsbn.TabIndex = 3;
            orderByIsbn.TabStop = true;
            orderByIsbn.Text = "По ISBN";
            orderByIsbn.UseVisualStyleBackColor = true;
            // 
            // orderByPublisher
            // 
            orderByPublisher.AutoSize = true;
            orderByPublisher.Location = new Point(9, 41);
            orderByPublisher.Name = "orderByPublisher";
            orderByPublisher.Size = new Size(171, 29);
            orderByPublisher.TabIndex = 2;
            orderByPublisher.Text = "По издательству";
            orderByPublisher.UseVisualStyleBackColor = true;
            // 
            // orderByDateButton
            // 
            orderByDateButton.AutoSize = true;
            orderByDateButton.Location = new Point(189, 6);
            orderByDateButton.Name = "orderByDateButton";
            orderByDateButton.Size = new Size(167, 29);
            orderByDateButton.TabIndex = 1;
            orderByDateButton.Text = "По дате выхода";
            orderByDateButton.UseVisualStyleBackColor = true;
            // 
            // orderByName
            // 
            orderByName.AutoSize = true;
            orderByName.Location = new Point(9, 6);
            orderByName.Name = "orderByName";
            orderByName.Size = new Size(147, 29);
            orderByName.TabIndex = 0;
            orderByName.Text = "По названию";
            orderByName.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(genreComboBox);
            panel2.Controls.Add(genreLabel);
            panel2.Location = new Point(0, 331);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 59);
            panel2.TabIndex = 7;
            // 
            // genreComboBox
            // 
            genreComboBox.FormattingEnabled = true;
            genreComboBox.Location = new Point(156, 14);
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(176, 33);
            genreComboBox.TabIndex = 2;
            // 
            // genreLabel
            // 
            genreLabel.Dock = DockStyle.Left;
            genreLabel.Location = new Point(0, 0);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(150, 59);
            genreLabel.TabIndex = 0;
            genreLabel.Text = "Жанр:";
            genreLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // authorNamePanel
            // 
            authorNamePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            authorNamePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            authorNamePanel.Controls.Add(authorNameComboBox);
            authorNamePanel.Controls.Add(authorNameLabel);
            authorNamePanel.Location = new Point(0, 272);
            authorNamePanel.Name = "authorNamePanel";
            authorNamePanel.Size = new Size(370, 59);
            authorNamePanel.TabIndex = 6;
            // 
            // authorNameComboBox
            // 
            authorNameComboBox.FormattingEnabled = true;
            authorNameComboBox.Location = new Point(156, 14);
            authorNameComboBox.Name = "authorNameComboBox";
            authorNameComboBox.Size = new Size(176, 33);
            authorNameComboBox.TabIndex = 1;
            // 
            // authorNameLabel
            // 
            authorNameLabel.Dock = DockStyle.Left;
            authorNameLabel.Location = new Point(0, 0);
            authorNameLabel.Name = "authorNameLabel";
            authorNameLabel.Size = new Size(150, 59);
            authorNameLabel.TabIndex = 0;
            authorNameLabel.Text = "Автор:";
            authorNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // isbnPanel
            // 
            isbnPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            isbnPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            isbnPanel.Controls.Add(isbnValueTextBox);
            isbnPanel.Controls.Add(isbnValueLabel);
            isbnPanel.Location = new Point(0, 213);
            isbnPanel.Name = "isbnPanel";
            isbnPanel.Size = new Size(370, 59);
            isbnPanel.TabIndex = 5;
            // 
            // isbnValueTextBox
            // 
            isbnValueTextBox.Location = new Point(156, 14);
            isbnValueTextBox.Name = "isbnValueTextBox";
            isbnValueTextBox.Size = new Size(176, 31);
            isbnValueTextBox.TabIndex = 1;
            // 
            // isbnValueLabel
            // 
            isbnValueLabel.Dock = DockStyle.Left;
            isbnValueLabel.Location = new Point(0, 0);
            isbnValueLabel.Name = "isbnValueLabel";
            isbnValueLabel.Size = new Size(150, 59);
            isbnValueLabel.TabIndex = 0;
            isbnValueLabel.Text = "ISBN: ";
            isbnValueLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bookPublisherPanel
            // 
            bookPublisherPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bookPublisherPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bookPublisherPanel.Controls.Add(bookPublisherNameTextBox);
            bookPublisherPanel.Controls.Add(publisherNameLabel);
            bookPublisherPanel.Location = new Point(0, 154);
            bookPublisherPanel.Name = "bookPublisherPanel";
            bookPublisherPanel.Size = new Size(370, 59);
            bookPublisherPanel.TabIndex = 4;
            // 
            // bookPublisherNameTextBox
            // 
            bookPublisherNameTextBox.Location = new Point(156, 14);
            bookPublisherNameTextBox.Name = "bookPublisherNameTextBox";
            bookPublisherNameTextBox.Size = new Size(176, 31);
            bookPublisherNameTextBox.TabIndex = 1;
            // 
            // publisherNameLabel
            // 
            publisherNameLabel.Dock = DockStyle.Left;
            publisherNameLabel.Location = new Point(0, 0);
            publisherNameLabel.Name = "publisherNameLabel";
            publisherNameLabel.Size = new Size(150, 59);
            publisherNameLabel.TabIndex = 0;
            publisherNameLabel.Text = "Издательство:";
            publisherNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bookPublishingDatePanel
            // 
            bookPublishingDatePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bookPublishingDatePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bookPublishingDatePanel.Controls.Add(bookPublishingDateNumericUpDown);
            bookPublishingDatePanel.Controls.Add(bookPublishingDateLabel);
            bookPublishingDatePanel.Location = new Point(0, 95);
            bookPublishingDatePanel.Name = "bookPublishingDatePanel";
            bookPublishingDatePanel.Size = new Size(370, 59);
            bookPublishingDatePanel.TabIndex = 3;
            // 
            // bookPublishingDateNumericUpDown
            // 
            bookPublishingDateNumericUpDown.Location = new Point(156, 15);
            bookPublishingDateNumericUpDown.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            bookPublishingDateNumericUpDown.Name = "bookPublishingDateNumericUpDown";
            bookPublishingDateNumericUpDown.Size = new Size(176, 31);
            bookPublishingDateNumericUpDown.TabIndex = 1;
            // 
            // bookPublishingDateLabel
            // 
            bookPublishingDateLabel.Dock = DockStyle.Left;
            bookPublishingDateLabel.Location = new Point(0, 0);
            bookPublishingDateLabel.Name = "bookPublishingDateLabel";
            bookPublishingDateLabel.Size = new Size(150, 59);
            bookPublishingDateLabel.TabIndex = 0;
            bookPublishingDateLabel.Text = "Дата выхода: ";
            bookPublishingDateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // selectBookNamePanel
            // 
            selectBookNamePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            selectBookNamePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            selectBookNamePanel.Controls.Add(bookNameSelectTextBox);
            selectBookNamePanel.Controls.Add(bookNameSelectLabel);
            selectBookNamePanel.Location = new Point(0, 36);
            selectBookNamePanel.Name = "selectBookNamePanel";
            selectBookNamePanel.Size = new Size(370, 59);
            selectBookNamePanel.TabIndex = 2;
            // 
            // bookNameSelectTextBox
            // 
            bookNameSelectTextBox.Location = new Point(156, 14);
            bookNameSelectTextBox.Name = "bookNameSelectTextBox";
            bookNameSelectTextBox.Size = new Size(176, 31);
            bookNameSelectTextBox.TabIndex = 1;
            // 
            // bookNameSelectLabel
            // 
            bookNameSelectLabel.Dock = DockStyle.Left;
            bookNameSelectLabel.Location = new Point(0, 0);
            bookNameSelectLabel.Name = "bookNameSelectLabel";
            bookNameSelectLabel.Size = new Size(150, 59);
            bookNameSelectLabel.TabIndex = 0;
            bookNameSelectLabel.Text = "Название книги:";
            bookNameSelectLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // findAndSortBooksLabel
            // 
            findAndSortBooksLabel.Dock = DockStyle.Top;
            findAndSortBooksLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            findAndSortBooksLabel.Location = new Point(0, 0);
            findAndSortBooksLabel.Name = "findAndSortBooksLabel";
            findAndSortBooksLabel.Size = new Size(370, 36);
            findAndSortBooksLabel.TabIndex = 1;
            findAndSortBooksLabel.Text = "Поиск и сортировка книг";
            findAndSortBooksLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // findBookButton
            // 
            findBookButton.BackColor = Color.DarkSalmon;
            findBookButton.Cursor = Cursors.Hand;
            findBookButton.Dock = DockStyle.Bottom;
            findBookButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            findBookButton.ForeColor = SystemColors.ControlText;
            findBookButton.Location = new Point(0, 651);
            findBookButton.Name = "findBookButton";
            findBookButton.Size = new Size(370, 34);
            findBookButton.TabIndex = 0;
            findBookButton.Text = "Найти книги";
            findBookButton.UseVisualStyleBackColor = false;
            // 
            // mainWindowTabs
            // 
            mainWindowTabs.Controls.Add(booksPage);
            mainWindowTabs.Controls.Add(findAndSortClients);
            mainWindowTabs.Dock = DockStyle.Fill;
            mainWindowTabs.Location = new Point(0, 34);
            mainWindowTabs.Margin = new Padding(0);
            mainWindowTabs.Name = "mainWindowTabs";
            mainWindowTabs.SelectedIndex = 0;
            mainWindowTabs.Size = new Size(1320, 729);
            mainWindowTabs.TabIndex = 3;
            // 
            // booksPage
            // 
            booksPage.Controls.Add(booksReviewPanel);
            booksPage.Location = new Point(4, 34);
            booksPage.Name = "booksPage";
            booksPage.Padding = new Padding(3);
            booksPage.Size = new Size(1312, 691);
            booksPage.TabIndex = 0;
            booksPage.Text = "Поиск и сортировка книг";
            booksPage.UseVisualStyleBackColor = true;
            // 
            // findAndSortClients
            // 
            findAndSortClients.Controls.Add(findAndSortReadersPanel);
            findAndSortClients.Controls.Add(readersPreviewDataGridView);
            findAndSortClients.Location = new Point(4, 34);
            findAndSortClients.Name = "findAndSortClients";
            findAndSortClients.Padding = new Padding(3);
            findAndSortClients.Size = new Size(1312, 691);
            findAndSortClients.TabIndex = 1;
            findAndSortClients.Text = "Поиск и сортировка клиентов";
            findAndSortClients.UseVisualStyleBackColor = true;
            // 
            // findAndSortReadersPanel
            // 
            findAndSortReadersPanel.Controls.Add(buttonsPanel);
            findAndSortReadersPanel.Controls.Add(ascDescOrderPanel);
            findAndSortReadersPanel.Controls.Add(fieldOrderPanel);
            findAndSortReadersPanel.Controls.Add(selectReaderSettingsPanel);
            findAndSortReadersPanel.Controls.Add(findAndSortReadersLabel);
            findAndSortReadersPanel.Dock = DockStyle.Fill;
            findAndSortReadersPanel.Location = new Point(920, 3);
            findAndSortReadersPanel.Name = "findAndSortReadersPanel";
            findAndSortReadersPanel.Padding = new Padding(10, 0, 0, 0);
            findAndSortReadersPanel.Size = new Size(389, 685);
            findAndSortReadersPanel.TabIndex = 3;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(resetButton);
            buttonsPanel.Controls.Add(findReadersButton);
            buttonsPanel.Dock = DockStyle.Bottom;
            buttonsPanel.Location = new Point(10, 560);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(379, 125);
            buttonsPanel.TabIndex = 6;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.WhiteSmoke;
            resetButton.Cursor = Cursors.Hand;
            resetButton.Dock = DockStyle.Bottom;
            resetButton.Location = new Point(0, 57);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(379, 34);
            resetButton.TabIndex = 13;
            resetButton.Text = "Сбросить параметры";
            resetButton.UseVisualStyleBackColor = false;
            // 
            // findReadersButton
            // 
            findReadersButton.BackColor = Color.DarkSalmon;
            findReadersButton.Cursor = Cursors.Hand;
            findReadersButton.Dock = DockStyle.Bottom;
            findReadersButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            findReadersButton.ForeColor = SystemColors.ControlText;
            findReadersButton.Location = new Point(0, 91);
            findReadersButton.Name = "findReadersButton";
            findReadersButton.Size = new Size(379, 34);
            findReadersButton.TabIndex = 12;
            findReadersButton.Text = "Найти читателей";
            findReadersButton.UseVisualStyleBackColor = false;
            // 
            // ascDescOrderPanel
            // 
            ascDescOrderPanel.Controls.Add(descendingReaderOrder);
            ascDescOrderPanel.Controls.Add(ascendingReaderOrder);
            ascDescOrderPanel.Dock = DockStyle.Top;
            ascDescOrderPanel.Location = new Point(10, 312);
            ascDescOrderPanel.Name = "ascDescOrderPanel";
            ascDescOrderPanel.Size = new Size(379, 73);
            ascDescOrderPanel.TabIndex = 5;
            // 
            // descendingReaderOrder
            // 
            descendingReaderOrder.AutoSize = true;
            descendingReaderOrder.Dock = DockStyle.Top;
            descendingReaderOrder.Location = new Point(0, 29);
            descendingReaderOrder.Name = "descendingReaderOrder";
            descendingReaderOrder.Size = new Size(379, 29);
            descendingReaderOrder.TabIndex = 3;
            descendingReaderOrder.Text = "По убыванию";
            descendingReaderOrder.UseVisualStyleBackColor = true;
            // 
            // ascendingReaderOrder
            // 
            ascendingReaderOrder.AutoSize = true;
            ascendingReaderOrder.Dock = DockStyle.Top;
            ascendingReaderOrder.Location = new Point(0, 0);
            ascendingReaderOrder.Name = "ascendingReaderOrder";
            ascendingReaderOrder.Size = new Size(379, 29);
            ascendingReaderOrder.TabIndex = 2;
            ascendingReaderOrder.Text = "По возрастанию";
            ascendingReaderOrder.UseVisualStyleBackColor = true;
            // 
            // fieldOrderPanel
            // 
            fieldOrderPanel.Controls.Add(orderByDebtor);
            fieldOrderPanel.Controls.Add(orderByAddress);
            fieldOrderPanel.Controls.Add(orderByPhone);
            fieldOrderPanel.Controls.Add(orderByReaderName);
            fieldOrderPanel.Dock = DockStyle.Top;
            fieldOrderPanel.Location = new Point(10, 188);
            fieldOrderPanel.Name = "fieldOrderPanel";
            fieldOrderPanel.Size = new Size(379, 124);
            fieldOrderPanel.TabIndex = 4;
            // 
            // orderByDebtor
            // 
            orderByDebtor.AutoSize = true;
            orderByDebtor.Dock = DockStyle.Top;
            orderByDebtor.Location = new Point(0, 87);
            orderByDebtor.Name = "orderByDebtor";
            orderByDebtor.Size = new Size(379, 29);
            orderByDebtor.TabIndex = 3;
            orderByDebtor.Text = "По наличию задолженностей";
            orderByDebtor.UseVisualStyleBackColor = true;
            // 
            // orderByAddress
            // 
            orderByAddress.AutoSize = true;
            orderByAddress.Dock = DockStyle.Top;
            orderByAddress.Location = new Point(0, 58);
            orderByAddress.Name = "orderByAddress";
            orderByAddress.Size = new Size(379, 29);
            orderByAddress.TabIndex = 2;
            orderByAddress.Text = "По адресу";
            orderByAddress.UseVisualStyleBackColor = true;
            // 
            // orderByPhone
            // 
            orderByPhone.AutoSize = true;
            orderByPhone.Dock = DockStyle.Top;
            orderByPhone.Location = new Point(0, 29);
            orderByPhone.Name = "orderByPhone";
            orderByPhone.Size = new Size(379, 29);
            orderByPhone.TabIndex = 1;
            orderByPhone.Text = "По номеру телефона";
            orderByPhone.UseVisualStyleBackColor = true;
            // 
            // orderByReaderName
            // 
            orderByReaderName.AutoSize = true;
            orderByReaderName.Dock = DockStyle.Top;
            orderByReaderName.Location = new Point(0, 0);
            orderByReaderName.Name = "orderByReaderName";
            orderByReaderName.Size = new Size(379, 29);
            orderByReaderName.TabIndex = 0;
            orderByReaderName.Text = "По ФИО";
            orderByReaderName.UseVisualStyleBackColor = true;
            // 
            // selectReaderSettingsPanel
            // 
            selectReaderSettingsPanel.Controls.Add(isDebtorPanel);
            selectReaderSettingsPanel.Controls.Add(readerAddressPanel);
            selectReaderSettingsPanel.Controls.Add(readerPhoneTextBox);
            selectReaderSettingsPanel.Controls.Add(readerNamePanel);
            selectReaderSettingsPanel.Dock = DockStyle.Top;
            selectReaderSettingsPanel.Location = new Point(10, 36);
            selectReaderSettingsPanel.Name = "selectReaderSettingsPanel";
            selectReaderSettingsPanel.Size = new Size(379, 152);
            selectReaderSettingsPanel.TabIndex = 3;
            // 
            // isDebtorPanel
            // 
            isDebtorPanel.Controls.Add(isDebtorComboBox);
            isDebtorPanel.Controls.Add(isDebtorLabel);
            isDebtorPanel.Dock = DockStyle.Top;
            isDebtorPanel.Location = new Point(0, 108);
            isDebtorPanel.Name = "isDebtorPanel";
            isDebtorPanel.Size = new Size(379, 36);
            isDebtorPanel.TabIndex = 3;
            // 
            // isDebtorComboBox
            // 
            isDebtorComboBox.DisplayMember = "Не важно";
            isDebtorComboBox.Dock = DockStyle.Top;
            isDebtorComboBox.FormattingEnabled = true;
            isDebtorComboBox.Items.AddRange(new object[] { "Не важно", "Да", "Нет" });
            isDebtorComboBox.Location = new Point(120, 0);
            isDebtorComboBox.Name = "isDebtorComboBox";
            isDebtorComboBox.Size = new Size(259, 33);
            isDebtorComboBox.TabIndex = 1;
            isDebtorComboBox.Text = "Не важно";
            isDebtorComboBox.ValueMember = "Не важно";
            // 
            // isDebtorLabel
            // 
            isDebtorLabel.Dock = DockStyle.Left;
            isDebtorLabel.Location = new Point(0, 0);
            isDebtorLabel.Name = "isDebtorLabel";
            isDebtorLabel.Size = new Size(120, 36);
            isDebtorLabel.TabIndex = 0;
            isDebtorLabel.Text = "Должник: ";
            isDebtorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // readerAddressPanel
            // 
            readerAddressPanel.Controls.Add(readerAddressTextBox);
            readerAddressPanel.Controls.Add(readerAddressLabel);
            readerAddressPanel.Dock = DockStyle.Top;
            readerAddressPanel.Location = new Point(0, 72);
            readerAddressPanel.Name = "readerAddressPanel";
            readerAddressPanel.Size = new Size(379, 36);
            readerAddressPanel.TabIndex = 2;
            // 
            // readerAddressTextBox
            // 
            readerAddressTextBox.Dock = DockStyle.Fill;
            readerAddressTextBox.Location = new Point(120, 0);
            readerAddressTextBox.Name = "readerAddressTextBox";
            readerAddressTextBox.Size = new Size(259, 31);
            readerAddressTextBox.TabIndex = 1;
            // 
            // readerAddressLabel
            // 
            readerAddressLabel.Dock = DockStyle.Left;
            readerAddressLabel.Location = new Point(0, 0);
            readerAddressLabel.Name = "readerAddressLabel";
            readerAddressLabel.Size = new Size(120, 36);
            readerAddressLabel.TabIndex = 0;
            readerAddressLabel.Text = "Адрес";
            readerAddressLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // readerPhoneTextBox
            // 
            readerPhoneTextBox.Controls.Add(textBox2);
            readerPhoneTextBox.Controls.Add(phoneNumberLabel);
            readerPhoneTextBox.Dock = DockStyle.Top;
            readerPhoneTextBox.Location = new Point(0, 36);
            readerPhoneTextBox.Name = "readerPhoneTextBox";
            readerPhoneTextBox.Size = new Size(379, 36);
            readerPhoneTextBox.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(120, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 31);
            textBox2.TabIndex = 1;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Dock = DockStyle.Left;
            phoneNumberLabel.Location = new Point(0, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(120, 36);
            phoneNumberLabel.TabIndex = 0;
            phoneNumberLabel.Text = "Телефон: ";
            phoneNumberLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // readerNamePanel
            // 
            readerNamePanel.Controls.Add(readerNameTextBox);
            readerNamePanel.Controls.Add(readerNameLabel);
            readerNamePanel.Dock = DockStyle.Top;
            readerNamePanel.Location = new Point(0, 0);
            readerNamePanel.Name = "readerNamePanel";
            readerNamePanel.Size = new Size(379, 36);
            readerNamePanel.TabIndex = 0;
            // 
            // readerNameTextBox
            // 
            readerNameTextBox.Dock = DockStyle.Fill;
            readerNameTextBox.Location = new Point(120, 0);
            readerNameTextBox.Name = "readerNameTextBox";
            readerNameTextBox.Size = new Size(259, 31);
            readerNameTextBox.TabIndex = 1;
            // 
            // readerNameLabel
            // 
            readerNameLabel.Dock = DockStyle.Left;
            readerNameLabel.Location = new Point(0, 0);
            readerNameLabel.Name = "readerNameLabel";
            readerNameLabel.Size = new Size(120, 36);
            readerNameLabel.TabIndex = 0;
            readerNameLabel.Text = "ФИО:";
            readerNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // findAndSortReadersLabel
            // 
            findAndSortReadersLabel.Dock = DockStyle.Top;
            findAndSortReadersLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            findAndSortReadersLabel.Location = new Point(10, 0);
            findAndSortReadersLabel.Name = "findAndSortReadersLabel";
            findAndSortReadersLabel.Size = new Size(379, 36);
            findAndSortReadersLabel.TabIndex = 2;
            findAndSortReadersLabel.Text = "Поиск и сортировка книг";
            findAndSortReadersLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // readersPreviewDataGridView
            // 
            readersPreviewDataGridView.AllowUserToAddRows = false;
            readersPreviewDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            readersPreviewDataGridView.BackgroundColor = Color.PapayaWhip;
            readersPreviewDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            readersPreviewDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, readerName, phoneNumber, Address, isDebtor });
            readersPreviewDataGridView.Dock = DockStyle.Left;
            readersPreviewDataGridView.Location = new Point(3, 3);
            readersPreviewDataGridView.Name = "readersPreviewDataGridView";
            readersPreviewDataGridView.ReadOnly = true;
            readersPreviewDataGridView.RowHeadersVisible = false;
            readersPreviewDataGridView.RowHeadersWidth = 62;
            readersPreviewDataGridView.Size = new Size(917, 685);
            readersPreviewDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 15.794117F;
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // readerName
            // 
            readerName.HeaderText = "ФИО";
            readerName.MinimumWidth = 8;
            readerName.Name = "readerName";
            readerName.ReadOnly = true;
            // 
            // phoneNumber
            // 
            phoneNumber.HeaderText = "Телефон";
            phoneNumber.MinimumWidth = 8;
            phoneNumber.Name = "phoneNumber";
            phoneNumber.ReadOnly = true;
            // 
            // Address
            // 
            Address.HeaderText = "Адрес";
            Address.MinimumWidth = 8;
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // isDebtor
            // 
            isDebtor.HeaderText = "Должник?";
            isDebtor.MinimumWidth = 8;
            isDebtor.Name = "isDebtor";
            isDebtor.ReadOnly = true;
            // 
            // MainLibraryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1320, 763);
            Controls.Add(mainWindowTabs);
            Controls.Add(addBookToDataBaseToolStrip);
            Name = "MainLibraryForm";
            Text = "Библиотека";
            addBookToDataBaseToolStrip.ResumeLayout(false);
            addBookToDataBaseToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)booksReviewDataGridView).EndInit();
            booksReviewPanel.ResumeLayout(false);
            doSelectQueryPanel.ResumeLayout(false);
            ascendingDescendingPanel.ResumeLayout(false);
            ascendingDescendingPanel.PerformLayout();
            orderByPanel.ResumeLayout(false);
            orderByPanel.PerformLayout();
            panel2.ResumeLayout(false);
            authorNamePanel.ResumeLayout(false);
            isbnPanel.ResumeLayout(false);
            isbnPanel.PerformLayout();
            bookPublisherPanel.ResumeLayout(false);
            bookPublisherPanel.PerformLayout();
            bookPublishingDatePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bookPublishingDateNumericUpDown).EndInit();
            selectBookNamePanel.ResumeLayout(false);
            selectBookNamePanel.PerformLayout();
            mainWindowTabs.ResumeLayout(false);
            booksPage.ResumeLayout(false);
            findAndSortClients.ResumeLayout(false);
            findAndSortReadersPanel.ResumeLayout(false);
            buttonsPanel.ResumeLayout(false);
            ascDescOrderPanel.ResumeLayout(false);
            ascDescOrderPanel.PerformLayout();
            fieldOrderPanel.ResumeLayout(false);
            fieldOrderPanel.PerformLayout();
            selectReaderSettingsPanel.ResumeLayout(false);
            isDebtorPanel.ResumeLayout(false);
            readerAddressPanel.ResumeLayout(false);
            readerAddressPanel.PerformLayout();
            readerPhoneTextBox.ResumeLayout(false);
            readerPhoneTextBox.PerformLayout();
            readerNamePanel.ResumeLayout(false);
            readerNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)readersPreviewDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip addBookToDataBaseToolStrip;
        private ToolStripDropDownButton booksDropBoxToolStrip;
        private ToolStripMenuItem addBookToolStripMenuItem;
        private ToolStripMenuItem removeBookToolStripMenuItem;
        private ToolStripMenuItem giveOutBookToolStripMenuItem;
        private ToolStripDropDownButton clientsToolStripDropDownButton;
        private ToolStripMenuItem addReadersToolStripMenuItem;
        private ToolStripMenuItem removeReaderToolStripMenuItem;
        private ToolStripMenuItem editBookInfoToolStripMenuItem;
        private ToolStripMenuItem editReaderDataToolStripMenuItem;
        private ToolStripDropDownButton reportToolStripDropDownButton;
        private ToolStripMenuItem debtorReportToolStripMenuItem;
        private ToolStripMenuItem readerReportToolStripMenuItem;
        private ToolStripMenuItem bookReportToolStripMenuItem;
        private DataGridView booksReviewDataGridView;
        private Panel booksReviewPanel;
        private ToolStripMenuItem вернутьКнигуToolStripMenuItem;
        private Panel doSelectQueryPanel;
        private Button findBookButton;
        private Label findAndSortBooksLabel;
        private Panel selectBookNamePanel;
        private TextBox bookNameSelectTextBox;
        private Label bookNameSelectLabel;
        private Panel isbnPanel;
        private TextBox isbnValueTextBox;
        private Label isbnValueLabel;
        private Panel bookPublisherPanel;
        private TextBox bookPublisherNameTextBox;
        private Label publisherNameLabel;
        private Panel bookPublishingDatePanel;
        private NumericUpDown bookPublishingDateNumericUpDown;
        private Label bookPublishingDateLabel;
        private Panel panel2;
        private Label genreLabel;
        private Panel authorNamePanel;
        private Label authorNameLabel;
        private ComboBox genreComboBox;
        private ComboBox authorNameComboBox;
        private Panel orderByPanel;
        private RadioButton orderByName;
        private RadioButton orderByGenre;
        private RadioButton orderByAuthor;
        private RadioButton orderByIsbn;
        private RadioButton orderByPublisher;
        private RadioButton orderByDateButton;
        private Panel ascendingDescendingPanel;
        private RadioButton descendingOrder;
        private RadioButton ascendingOrder;
        private TabControl mainWindowTabs;
        private TabPage booksPage;
        private Button resetQuery;
        private TabPage findAndSortClients;
        private DataGridView readersPreviewDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn readerName;
        private DataGridViewTextBoxColumn phoneNumber;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn isDebtor;
        private Panel findAndSortReadersPanel;
        private Label findAndSortReadersLabel;
        private Panel selectReaderSettingsPanel;
        private Panel readerNamePanel;
        private TextBox readerNameTextBox;
        private Label readerNameLabel;
        private Panel readerPhoneTextBox;
        private TextBox textBox2;
        private Label phoneNumberLabel;
        private Panel readerAddressPanel;
        private TextBox readerAddressTextBox;
        private Label readerAddressLabel;
        private Panel isDebtorPanel;
        private ComboBox isDebtorComboBox;
        private Label isDebtorLabel;
        private Panel fieldOrderPanel;
        private RadioButton orderByAddress;
        private RadioButton orderByPhone;
        private RadioButton orderByReaderName;
        private Panel buttonsPanel;
        private Button resetButton;
        private Button findReadersButton;
        private Panel ascDescOrderPanel;
        private RadioButton descendingReaderOrder;
        private RadioButton ascendingReaderOrder;
        private RadioButton orderByDebtor;
        private DataGridViewTextBoxColumn bookId;
        private DataGridViewTextBoxColumn bookName;
        private DataGridViewTextBoxColumn yearOfPublishing;
        private DataGridViewTextBoxColumn bookAuthors;
        private DataGridViewTextBoxColumn bookGenres;
        private DataGridViewTextBoxColumn publisherName;
        private DataGridViewTextBoxColumn bookISBN;
        private DataGridViewTextBoxColumn readerID;
        private DataGridViewTextBoxColumn returnDate;
    }
}
