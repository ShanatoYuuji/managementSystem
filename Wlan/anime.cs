using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wlan
{
    class Anime 
    {
        private int Num;
        private string Name;
        private string Name_cn;
        private string Staff;
        private string LocalLink;
        private string DLink;
        private string Author;

        public int Num1
        {
            get
            {
                return Num;
            }

            set
            {
                Num = value;
            }
        }

        public string Name1
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public string Name_cn1
        {
            get
            {
                return Name_cn;
            }

            set
            {
                Name_cn = value;
            }
        }

        public string Staff1
        {
            get
            {
                return Staff;
            }

            set
            {
                Staff = value;
            }
        }

        public string LocalLink1
        {
            get
            {
                return LocalLink;
            }

            set
            {
                LocalLink = value;
            }
        }

        public string DLink1
        {
            get
            {
                return DLink;
            }

            set
            {
                DLink = value;
            }
        }

        public string Author1
        {
            get
            {
                return Author;
            }

            set
            {
                Author = value;
            }
        }
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Anime()
        {

        }
        /// <summary>
        /// 没有Num的构造函数
        /// </summary>
        /// <param name="Name">名字</param>
        /// <param name="Name_cn">中文名</param>
        /// <param name="Staff">staff</param>
        /// <param name="LocalLink">本地地址</param>
        /// <param name="DLink">磁力链接</param>
        /// <param name="Author">作者</param>
        public Anime(string Name,
                     string Name_cn,
                     string Staff,
                     string LocalLink,
                     string DLink,
                     string Author)
        {
            this.Name1 = Name;
            this.Name_cn1 = Name_cn;
            this.Staff1 = Staff;
            this.LocalLink1 = LocalLink;
            this.DLink1 = DLink;
            this.Author1 = Author;
        }
        /// <summary>
        ///全参构造函数
        /// </summary>
        /// <param name="Num">ID</param>
        /// <param name="Name">名字</param>
        /// <param name="Name_cn">中文名</param>
        /// <param name="Staff">staff</param>
        /// <param name="LocalLink">本地地址 </param>
        /// <param name="DLink">磁力链接</param>
        /// <param name="Author">作者</param>
        public Anime(int Num,
                     string Name,
                     string Name_cn,
                     string Staff,
                     string LocalLink,
                     string DLink,
                     string Author)
        {
            this.Num1 = Num;
            this.Name1 = Name;
            this.Name_cn1 = Name_cn;
            this.Staff1 = Staff;
            this.LocalLink1 = LocalLink;
            this.DLink1 = DLink;
            this.Author1 = Author;
        }


    }
}
