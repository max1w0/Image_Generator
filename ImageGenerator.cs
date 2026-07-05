using System.IO;
using System.Drawing;
using Microsoft.Data.SqlClient;

namespace ImageGenerator
{
    public static class ImageGenerator
    {
        public static Bitmap GenerateImage(int[][] illustrationOfFigures)
        {
            Bitmap bmpBGImage = new Bitmap(GetRandomBackgroundImage(), 480, 480);

            using (var graphics = Graphics.FromImage(bmpBGImage))
            {
                for (int y = 0; y < illustrationOfFigures.Length; y++)
                {
                    for (int x = 0; x < illustrationOfFigures[y].Length; x++)
                    {
                        Bitmap bmpToDraw = new Bitmap(120, 120);
                        switch (illustrationOfFigures[x][y])
                        {
                            case 1:
                                {
                                    bmpToDraw = new Bitmap(GetRandomElementImage(illustrationOfFigures[x][y]), 120, 120);

                                    break;
                                }
                            case 2:
                                {
                                    bmpToDraw = new Bitmap(GetRandomElementImage(illustrationOfFigures[x][y]), 120, 120);

                                    break;
                                }
                            case 3:
                                {
                                    bmpToDraw = new Bitmap(GetRandomElementImage(illustrationOfFigures[x][y]), 120, 120);

                                    break;
                                }
                        }
                        graphics.DrawImage(bmpToDraw, y * 120, x * 120);
                    }
                }
            }
            return bmpBGImage;
        }

        private static Bitmap GetRandomBackgroundImage()
        {
            string connectionString = "Data Source=SERVER;Initial Catalog=ImageGenerator;Integrated Security=True;Encrypt=False";
            string query = "SELECT TOP 1 image FROM background ORDER BY NEWID()";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    byte[] imageData = (byte[])command.ExecuteScalar();

                    if (imageData != null)
                    {
                        using (var ms = new MemoryStream(imageData))
                        {
                            return new Bitmap(ms);
                        }
                    }
                }
            }

            return null;
        }

        private static Bitmap GetRandomElementImage(int illustrationOfFigures)
        {
            string connectionString = "Data Source=SERVER;Initial Catalog=ImageGenerator;Integrated Security=True;Encrypt=False";
            string query = "SELECT TOP 1 image FROM paintings ORDER BY NEWID()";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    byte[] imageData = (byte[])command.ExecuteScalar();

                    if (imageData != null)
                    {
                        using (var ms = new MemoryStream(imageData))
                        {
                            return new Bitmap(ms);
                        }
                    }
                }
            }
            return null;
        }
    }
}

