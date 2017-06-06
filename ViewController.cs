using System;
using AppKit;
using Foundation;
using System.IO;

namespace TestReadWrite
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
        // ViewController.designer.csの定義を記述
        partial void btnRead(Foundation.NSObject sender)
        {
			// ファイルの存在チェック
			bool bRet = NSFileManager.DefaultManager.FileExists(textReadValue.StringValue);
            if (bRet)
            {
                // ファイル拡張子は、.txtのみにする
                var extension = Path.GetExtension(textReadValue.StringValue);
                if(extension == ".txt")
                {
					// ファイル読み込み
					var readdata = File.ReadAllText(textReadValue.StringValue);

					if (readdata != null)
					{
						// TextViewに読み込みデータ表示
						textviewReadValue.Value = readdata.ToString();
					}
					else
					{
						// TextViewにエラー表示
						textviewReadValue.Value = "Not Data...";
					} 
                }
                else
                {
					// TextViewにエラー表示
					textviewReadValue.Value = "FileExtension is .txt Only...";
				}
            }
            else
            {
				// TextViewにエラー表示
				textviewReadValue.Value = "File Not Found...";         
            }
        }
        // ViewController.designer.csの定義を記述
        partial void btnWrite(Foundation.NSObject sender)
        {
            var extension = Path.GetExtension(textWriteValue.StringValue);
            if (extension == ".txt")
            {
                if(textviewWriteValue.Value != null)
                {
                    var filepath = Path.GetDirectoryName(textWriteValue.StringValue);
                    // ディレクトリ確認
                    bool bRet = NSFileManager.DefaultManager.FileExists(filepath);
                    if(bRet)
                    {
                        File.WriteAllText(textWriteValue.StringValue, textviewWriteValue.Value);
                    }
                    else
                    {
						// TextViewにエラー表示
						textviewWriteValue.Value = "Directory Not Found...";           
                    }
                }
                else
                {
					// TextViewにエラー表示
					textviewWriteValue.Value = "Not Data...";
                }
            }
			else
			{
				// TextViewにエラー表示
				textviewWriteValue.Value = "FileExtension is .txt Only...";
			}
        }
    }
}