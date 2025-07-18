﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public class Books
    {
        public string BookID { get; set; }
        public DateTime Timestamp { get; set; } 
        public string Name { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public Books Left { get; set; }
        public Books Right { get; set; }


        public Books(string bookID, DateTime timestamp, string name, string author, string category)
        {
            BookID = bookID;
            Timestamp = timestamp;
            Name = name;
            Author = author;
            Category = category;
            Left = null;
            Right = null;
        }


        public void Insert(Books newBook)
        {
            if (newBook.Timestamp < this.Timestamp)  
            {
                if (this.Left == null)
                    this.Left = newBook;
                else
                    this.Left.Insert(newBook); 
            }
            else  
            {
                if (this.Right == null)
                    this.Right = newBook;
                else
                    this.Right.Insert(newBook); 
            }
        }


        public void InOrderTraversal(Action<Books> action)
        {
            if (this.Left != null)
                this.Left.InOrderTraversal(action); 
            action(this); 
            if (this.Right != null)
                this.Right.InOrderTraversal(action); 
        }

        public Books Delete(string bookID, DateTime timestamp)
        {
            if (timestamp < this.Timestamp)
            {
                if (this.Left != null)
                    this.Left = this.Left.Delete(bookID, timestamp);
            }
            else if (timestamp > this.Timestamp)
            {
                if (this.Right != null)
                    this.Right = this.Right.Delete(bookID, timestamp);
            }
            else if (this.BookID == bookID)
            {
                // Trường hợp không có con
                if (Left == null && Right == null)
                    return null;

                // Trường hợp chỉ có 1 con
                if (Left == null)
                    return Right;
                if (Right == null)
                    return Left;

                // Trường hợp có 2 con: tìm node nhỏ nhất bên phải
                Books minNode = Right;
                while (minNode.Left != null)
                    minNode = minNode.Left;

                // Gán thông tin node nhỏ nhất sang node hiện tại
                this.BookID = minNode.BookID;
                this.Timestamp = minNode.Timestamp;
                this.Name = minNode.Name;
                this.Author = minNode.Author;
                this.Category = minNode.Category;

                // Xóa node nhỏ nhất bên phải (đã chuyển lên)
                this.Right = this.Right.Delete(minNode.BookID, minNode.Timestamp);
            }

            return this;
        }

        // Tìm sách có ngày xuất bản sớm nhất (node trái nhất)
        public Books FindOldest()
        {
            Books current = this;
            while (current.Left != null)
                current = current.Left;
            return current;
        }

        // Tìm sách có ngày xuất bản muộn nhất (node phải nhất)
        public Books FindLatest()
        {
            Books current = this;
            while (current.Right != null)
                current = current.Right;
            return current;
        }



    }


}
