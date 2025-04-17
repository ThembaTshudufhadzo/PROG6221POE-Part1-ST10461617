using System;
using System.Drawing;
using System.IO;
using System.Text;

namespace CyberSecurityChatbotApp
{
    public class DisplayMediaArt
    {
        // Class to display the logo using ASCII art
        public static void DisplayLogoAndInfo(int maxWidth = 60) // Added maxWidth parameter with a default value
        {
            Console.ForegroundColor = ConsoleColor.Red;

            // Absolute path
            string imagePath = @"C:\Users\lab_services_student\Desktop\CyberSecurityChatbotApp\Resources\cs2 (2).jpg";
            Console.WriteLine($"Attempting to display logo from: {imagePath}");

            // Check if the file exists:
            if (!File.Exists(imagePath))
            {
                Console.WriteLine($"Error: Image file not found at {imagePath}");
                Console.ResetColor();
                Console.WriteLine("  **CyberSecurity Awareness Bot**");
                Console.WriteLine("__________________________________");
                return;
            }

            // Use the maxWidth parameter here
            string asciiArt = ConvertImageToASCII(imagePath, maxWidth);
            if (asciiArt != null)
            {
                Console.WriteLine(asciiArt);
            }
            else
            {
                Console.WriteLine("Error: Could not display logo.");
            }
            Console.ResetColor();
            Console.WriteLine("  **CyberSecurity Awareness Bot**");
            Console.WriteLine("__________________________________");
        }

        static string ConvertImageToASCII(string imagePath, int maxWidth) //  maxWidth parameter
        {
            try
            {
                if (!File.Exists(imagePath))
                {
                    Console.WriteLine($"Error: Image file not found at {imagePath}");
                    return null;
                }

                // Load the image
                Bitmap img = new Bitmap(imagePath);

                // Calculate the aspect ratio
                float ratio = (float)img.Height / img.Width;

                // Use the provided maxWidth
                int newWidth = Math.Min(maxWidth, img.Width);
                int newHeight = (int)(newWidth * ratio);

                // Create a resized bitmap
                Bitmap resized = new Bitmap(newWidth, newHeight);

                // Use Graphics to draw the original image onto the resized bitmap
                using (Graphics g = Graphics.FromImage(resized))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.DrawImage(img, 0, 0, newWidth, newHeight);
                }

                // Build the ASCII string
                StringBuilder sb = new StringBuilder();

                for (int y = 0; y < resized.Height; y++)
                {
                    for (int x = 0; x < resized.Width; x++)
                    {
                        Color c = resized.GetPixel(x, y);
                        int intensity = (int)(0.299 * c.R + 0.587 * c.G + 0.114 * c.B);
                        int index = Math.Min(intensity * 9 / 255, 8);
                        char[] asciiChars = { '.', ',', ':', '+', '*', '?', '%', '#', '@' };
                        sb.Append(asciiChars[index]);
                    }
                    sb.AppendLine();
                }

                resized.Dispose();
                img.Dispose();
                return sb.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting image: {ex.Message}");
                return null;
            }
        }
    }
}
