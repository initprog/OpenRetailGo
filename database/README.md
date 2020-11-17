Struktur Database OpenRetailGo
==============================================

OpenRetailGo menggunakan database [PostgreSQL](https://www.postgresql.org/) versi 13, disarankan Anda menggunakan versi yang sama untuk meminimalkan issue kompatibilitas.

Import Database OpenRetailGo
-----------------------------------------------
Untuk meng-import database OpenRetailGo Anda bisa menggunakan tool [psql](https://www.postgresql.org/docs/9.2/static/app-psql.html) dengan perintah berikut: 

```
psql -U <username> OpenRetailGo < OpenRetailGo.sql
```

Untuk `username` bisa menggunakan user default [PostgreSQL](https://www.postgresql.org/) yaitu `postgres`, dan pastikan sebelum menjalankan perintah di atas database `OpenRetailGo` sudah dibuat terlebih dulu.

Import Data Awal (prerequisites)
-----------------------------------------------
Sama seperti meng-import database OpenRetailGo, kita juga bisa menggunakan tool [psql](https://www.postgresql.org/docs/9.2/static/app-psql.html) dengan perintah berikut: 

```
psql -U postgres OpenRetailGo < 01_data-menu.sql
psql -U postgres OpenRetailGo < 02_data-item_menu.sql
psql -U postgres OpenRetailGo < 03_data-role.sql
psql -U postgres OpenRetailGo < 04_data-role_privilege.sql
psql -U postgres OpenRetailGo < 05_data-pengguna.sql
psql -U postgres OpenRetailGo < 06_data-alasan_penyesuaian_stok.sql
psql -U postgres OpenRetailGo < 07_data-database_version.sql
psql -U postgres OpenRetailGo < 08_data-jenis_pengeluaran.sql
psql -U postgres OpenRetailGo < 09_data-jabatan.sql
psql -U postgres OpenRetailGo < 10_data-profil.sql
psql -U postgres OpenRetailGo < 11_data-header-nota.sql
psql -U postgres OpenRetailGo < 12_data-label-nota.sql
psql -U postgres OpenRetailGo < 13_data-provinsi.sql
psql -U postgres OpenRetailGo < 14_data-kabupaten.sql
psql -U postgres OpenRetailGo < 15_data-header_nota_mini_pos.sql
psql -U postgres OpenRetailGo < 16_data-footer_nota_mini_pos.sql
psql -U postgres OpenRetailGo < 17_data-kartu.sql
psql -U postgres OpenRetailGo < 18_data-setting_aplikasi.sql
psql -U postgres OpenRetailGo < 19_data-provinsi2.sql
psql -U postgres OpenRetailGo < 20_data-kabupaten2.sql
psql -U postgres OpenRetailGo < 21_data-kecamatan.sql
```

Untuk hemat waktu: copy semua command diatas lalu paste di command prompt.
