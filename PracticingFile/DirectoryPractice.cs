
namespace PracticingFile
{
    public static class DirectoryPractice
    {
        public static void getFiles()
        {
            DirectoryInfo dir1 = new DirectoryInfo(@"C:\MyCode\");
            dir1.Create();

            dir1.Delete();

            Console.ReadLine();

        }

        public static void ShowWindowsDirectoryInfo()
        {
            // Dump directory information. If you are not on Windows, plug in another directory
            DirectoryInfo dir = new DirectoryInfo($@"C{Path.VolumeSeparatorChar}{Path.
            DirectorySeparatorChar}Windows");
            Console.WriteLine("***** Directory Info *****");
            Console.WriteLine("FullName: {0}", dir.FullName);
            Console.WriteLine("Name: {0}", dir.Name);
            Console.WriteLine("Parent: {0}", dir.Parent);
            Console.WriteLine("Creation: {0}", dir.CreationTime);
            Console.WriteLine("Attributes: {0}", dir.Attributes);
            Console.WriteLine("Root: {0}", dir.Root);
            Console.WriteLine("**************************\n");
        }
        public static void DisplayImageFiles()
        {
            DirectoryInfo dir = new
            DirectoryInfo($@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}Windows{Path.
            DirectorySeparatorChar}Web{Path.DirectorySeparatorChar}Wallpaper");

            // Get all files with a *.jpg extension.
            FileInfo[] imageFiles = dir.GetFiles("*.jpg", SearchOption.AllDirectories);

            // How many were found?
            Console.WriteLine("Found {0} *.jpg files\n", imageFiles.Length);

            // Now print out info for each file.
            foreach (FileInfo f in imageFiles)
            {
                Console.WriteLine("***************************");
                Console.WriteLine("File name: {0}", f.Name);
                Console.WriteLine("File size: {0}", f.Length);
                Console.WriteLine("Creation: {0}", f.CreationTime);
                Console.WriteLine("Attributes: {0}", f.Attributes);
                Console.WriteLine("***************************\n");
            }


        }

        public static void ModifyAppDirectory()
        {
            DirectoryInfo myDirectory = new DirectoryInfo(".");

            myDirectory.CreateSubdirectory("MyFolder");
            Directory.Delete("MyFolder");

        }


        public static void FunWithDirectoryType()
        {
            string[] drives = Directory.GetLogicalDrives();

            Console.WriteLine("Drives in the Directory are:\n");
            foreach (string drive in drives)
            {
                Console.WriteLine($"---> {drive}");
            }

            //Working with the DriveInfo Class Type
            DriveInfo[] myDrives = DriveInfo.GetDrives();
            // Now print drive stats.
            foreach (DriveInfo d in myDrives)
            {
                Console.WriteLine("Name: {0}", d.Name);
                Console.WriteLine("Type: {0}", d.DriveType);
            }


        }
    }
}
