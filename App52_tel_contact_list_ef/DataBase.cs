using Microsoft.EntityFrameworkCore;

namespace App52_tel_contact_list_ef;

public class DataBase : DbContext{ // EF Core içinde bulunan DbContext. DbContext'in bütün özelliklerini aldık.
    public DbSet<Person> People {get; set;} // kişiler tablosunu oluşturduk veritabanında

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlite("Data source = /Users/kerimkarakan/BTK_Akademi_CSharp_Ocak_2025/contact_list.db");
    }
}
