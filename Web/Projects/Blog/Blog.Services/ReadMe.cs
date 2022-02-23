/// <summary>
/// 1. auth brachi yaratdiq
/// 2. UserConfigurationda seedlerimizi elave eledik
///     2.1 CreatePasswordHash(User user, string password) -bu metod vasitesi ile pawwordu hashleyib geri qaytardiq 
///         Cunki biz databasede passwordleri aciq formada saxlamiriqki, sabah databemizi eger hacklenerse hemen hacker 
///         o passwordlari aciq sekilde gore bilmesin
///     2.2 member.PasswordHash = CreatePasswordHash(editor, "Member123!User"); - memberin PasswordHash propertisine 
///         CreatePasswordHash(editor, "Member123!User") deyerini verdik
///     2.3 builder.HasData(admin, editor, member);
/// 3. RoleConfigurationda seedlerimizi elave eledik 
///     3.1 Hem userde hem rolede id-leri elle vermisik, cunki ilk yarananlardir deye biz yaziriqki sonradan avtomatik
///         generate ede bilsin.
/// </summary>
