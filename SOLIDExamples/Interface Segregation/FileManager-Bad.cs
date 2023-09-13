using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation {
	internal interface FileManager {
		public void ReadFile(string filePath);

		public void WriteFile(string filePath);

		public void EncryptFile(string filePath, string encryptionKey);

		public void DecryptFile(string filePath, string encryptionKey);
	}
}
