using System.Data.SqlClient;

namespace ExpenseManagementSystemsVBDotNet
{
    internal static class DatabaseInitializer
    {
        private const string ServerConn =
            @"Data Source=BEST-TECHNOLOGY\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;";

        private const string DbName = "ExpenseManagementSystemDBPrj";

        public static void EnsureCreated()
        {
            CreateDatabase();
            CreateTablesAndRelations();
        }

        private static void CreateDatabase()
        {
            using var con = new SqlConnection(ServerConn);
            con.Open();

            string sql = $@"
IF DB_ID(N'{DbName}') IS NULL
BEGIN
    CREATE DATABASE [{DbName}];
END
";
            using var cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }

        private static void CreateTablesAndRelations()
        {
            string dbConn =
                @"Data Source=BEST-TECHNOLOGY\SQLEXPRESS;Initial Catalog=" + DbName + @";Integrated Security=True;";

            using var con = new SqlConnection(dbConn);
            con.Open();

            string sql = @"
---------------------------
-- 1) TABLES (si absentes)
---------------------------

-- USERS
IF OBJECT_ID('dbo.tblUsers','U') IS NULL
BEGIN
    CREATE TABLE dbo.tblUsers(
        id INT IDENTITY(1,1) PRIMARY KEY,
        username NVARCHAR(100) NOT NULL UNIQUE,
        password NVARCHAR(100) NOT NULL,
        date_create DATETIME DEFAULT GETDATE()
    );
END

-- CATEGORIES
IF OBJECT_ID('dbo.tblCategories','U') IS NULL
BEGIN
    CREATE TABLE dbo.tblCategories(
        id INT IDENTITY(1,1) PRIMARY KEY,
        user_id INT NOT NULL,
        category NVARCHAR(100) NOT NULL,
        type NVARCHAR(50) NULL,
        status NVARCHAR(50) NULL,
        date_insert DATE NULL
    );
END

-- EXPENSES
IF OBJECT_ID('dbo.tblExpenses','U') IS NULL
BEGIN
    CREATE TABLE dbo.tblExpenses(
        id INT IDENTITY(1,1) PRIMARY KEY,
        user_id INT NOT NULL,
        category NVARCHAR(100) NULL,
        item NVARCHAR(100) NULL,
        expense DECIMAL(18,2) NULL,
        description NVARCHAR(255) NULL,
        date_expense DATE NULL,
        date_insert DATE NULL
    );
END

-- INCOMES
IF OBJECT_ID('dbo.tblIncomes','U') IS NULL
BEGIN
    CREATE TABLE dbo.tblIncomes(
        id INT IDENTITY(1,1) PRIMARY KEY,
        user_id INT NOT NULL,
        category NVARCHAR(100) NULL,
        item NVARCHAR(100) NULL,
        income DECIMAL(18,2) NULL,
        description NVARCHAR(255) NULL,
        date_income DATE NULL,
        date_insert DATE NULL
    );
END

--------------------------------------------
-- 2) PATCH colonnes si tables déjà exist
--------------------------------------------

IF COL_LENGTH('dbo.tblCategories','date_insert') IS NULL
    ALTER TABLE dbo.tblCategories ADD date_insert DATE NULL;

IF COL_LENGTH('dbo.tblExpenses','date_expense') IS NULL
    ALTER TABLE dbo.tblExpenses ADD date_expense DATE NULL;
IF COL_LENGTH('dbo.tblExpenses','date_insert') IS NULL
    ALTER TABLE dbo.tblExpenses ADD date_insert DATE NULL;

IF COL_LENGTH('dbo.tblIncomes','date_income') IS NULL
    ALTER TABLE dbo.tblIncomes ADD date_income DATE NULL;
IF COL_LENGTH('dbo.tblIncomes','date_insert') IS NULL
    ALTER TABLE dbo.tblIncomes ADD date_insert DATE NULL;

-- user_id ajout avec DEFAULT(0) si pas existant (pour ne pas casser anciennes données)
IF COL_LENGTH('dbo.tblCategories','user_id') IS NULL
    ALTER TABLE dbo.tblCategories ADD user_id INT NOT NULL CONSTRAINT DF_tblCategories_user_id DEFAULT(0);

IF COL_LENGTH('dbo.tblExpenses','user_id') IS NULL
    ALTER TABLE dbo.tblExpenses ADD user_id INT NOT NULL CONSTRAINT DF_tblExpenses_user_id DEFAULT(0);

IF COL_LENGTH('dbo.tblIncomes','user_id') IS NULL
    ALTER TABLE dbo.tblIncomes ADD user_id INT NOT NULL CONSTRAINT DF_tblIncomes_user_id DEFAULT(0);

----------------------------------------------------
-- 3) Seed user SYSTEM si nécessaire
-- (pour éviter que user_id=0 casse les FK)
----------------------------------------------------
IF NOT EXISTS(SELECT 1 FROM dbo.tblUsers WHERE username = 'SYSTEM')
BEGIN
    INSERT INTO dbo.tblUsers(username, password, date_create)
    VALUES('SYSTEM', 'SYSTEM', GETDATE());
END

----------------------------------------------------
-- 4) FOREIGN KEYS Users (1) -> (Many) tables
----------------------------------------------------

-- FK: Categories -> Users
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = 'FK_tblCategories_tblUsers')
BEGIN
    ALTER TABLE dbo.tblCategories
    ADD CONSTRAINT FK_tblCategories_tblUsers
    FOREIGN KEY (user_id) REFERENCES dbo.tblUsers(id)
    ON DELETE CASCADE;
END

-- FK: Expenses -> Users
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = 'FK_tblExpenses_tblUsers')
BEGIN
    ALTER TABLE dbo.tblExpenses
    ADD CONSTRAINT FK_tblExpenses_tblUsers
    FOREIGN KEY (user_id) REFERENCES dbo.tblUsers(id)
    ON DELETE CASCADE;
END

-- FK: Incomes -> Users
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = 'FK_tblIncomes_tblUsers')
BEGIN
    ALTER TABLE dbo.tblIncomes
    ADD CONSTRAINT FK_tblIncomes_tblUsers
    FOREIGN KEY (user_id) REFERENCES dbo.tblUsers(id)
    ON DELETE CASCADE;
END
";

            using var cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
    }
}