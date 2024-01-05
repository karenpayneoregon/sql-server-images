# About

NorthWind Category table used a Image column to represent a category picture and today the recommendation is to use varbinary.

Steps

1. Created a windows forms project via a TableAdapter, displayed data. Each image was snapped shoted with SnagIt and saved to disk.
1. Added Photo column as varbinary
1. Reversed engineered NorthWind2024, only the category table.
1. Used EF Core to add each image to the new column.
1. Created a Forms 4.8 project to validate images work in a C# application.

Time taken, 30 minutes.
