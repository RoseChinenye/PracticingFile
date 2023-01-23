
namespace PracticingFile
{
    public static class FileIO
    {
        public static void CreateFile()
        {
            var fileName = ($@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}Test.dat");
            FileInfo f1 = new FileInfo(fileName);

            using (FileStream sf1 = f1.Create())
            {

            }

            f1.Delete();
        }
        
        public static void OpenFile()
        {
            var fileName = ($@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}Test.dat");
            FileInfo f2 = new FileInfo(fileName);

            using (FileStream sf2 = f2.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            {

            }
            f2.Delete();
        }

        public static void OpenReadAndOpenWrite()
        {
            var fileName = ($@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}Test.dat");
            FileInfo f3 = new FileInfo(fileName);
            
            f3.Create().Close();
            
            using (FileStream readOnlyStream = f3.OpenRead())
            {

            }
            f3.Delete();

            // Now get a FileStream object with write-only permissions.
            FileInfo f4 = new FileInfo(fileName);
            using (FileStream writeOnlyStream = f4.OpenWrite())
            {
                // Use the FileStream object...
            }
            f4.Delete();
        }


        public static void OpenText()
        {
            var fileName = $@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}Test.dat";
           
            // Get a StreamReader object.
            //If not on a Windows machine, change the file name accordingly
            FileInfo f5 = new FileInfo(fileName);
            //File must exist before using OpenText
            f5.Create().Close();
            
            using (StreamReader sreader = f5.OpenText())
            {
                // Use the StreamReader object...
            }
            f5.Delete();
        }

        public static void CreateTextAndOpenText()
        {
            var fileName = $@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}Test.dat";
            
            FileInfo f6 = new FileInfo(fileName);
            using (StreamWriter swriter = f6.CreateText())
            {
                // Use the StreamWriter object...
            }
            f6.Delete();
            FileInfo f7 = new FileInfo(fileName);
            using (StreamWriter swriterAppend = f7.AppendText())
            {
                // Use the StreamWriter object...
            }
            f7.Delete();
        }
    }
}
