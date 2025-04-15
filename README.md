
# Thư viện Cấu trúc Dữ liệu và Giải thuật (DSA Library)

Kho lưu trữ này chứa các triển khai các cấu trúc dữ liệu và giải thuật cơ bản bằng ngôn ngữ **C++**. Mục tiêu nhằm phục vụ cho việc học tập, luyện tập lập trình và ôn tập phỏng vấn.

## 📁 Cấu trúc thư mục

Thư mục `main` được tổ chức rõ ràng theo từng chủ đề DSA:

```
.
├── LinkedList
│   ├── singly_linked_list.cpp         # Danh sách liên kết đơn
│   └── doubly_linked_list.cpp         # Danh sách liên kết đôi
├── Stack
│   └── stack_using_array.cpp          # Stack dùng mảng
├── Queue
│   ├── queue_using_array.cpp          # Hàng đợi dùng mảng
│   └── circular_queue.cpp             # Hàng đợi vòng
├── Tree
│   ├── binary_tree.cpp                # Cây nhị phân
│   └── binary_search_tree.cpp         # Cây tìm kiếm nhị phân
├── Searching
│   ├── linear_search.cpp              # Tìm kiếm tuyến tính
│   └── binary_search.cpp              # Tìm kiếm nhị phân
├── Sorting
│   ├── bubble_sort.cpp                # Sắp xếp nổi bọt
│   ├── selection_sort.cpp             # Sắp xếp chọn
│   └── quick_sort.cpp                 # Sắp xếp nhanh
└── README.md
```

> 📌 Tất cả các chương trình được viết bằng **C++**, dễ hiểu và phù hợp cho người mới bắt đầu.

## ✅ Chủ đề đã triển khai

- **Danh sách liên kết** (đơn & đôi)
- **Ngăn xếp (Stack)** & **Hàng đợi (Queue)** – có cả dạng vòng
- **Cây** – Cây nhị phân và Cây tìm kiếm nhị phân
- **Thuật toán tìm kiếm** – Tuyến tính và nhị phân
- **Thuật toán sắp xếp** – Nổi bọt, chọn, nhanh

## 🛠 Cách sử dụng

1. Clone kho lưu trữ:
   ```bash
   git clone https://github.com/thilinnd/dsa_library.git
   cd dsa_library
   ```

2. Biên dịch và chạy một chương trình `.cpp` bất kỳ:
   ```bash
   g++ LinkedList/singly_linked_list.cpp -o sll
   ./sll
   ```

## 🎯 Mục đích

Thư viện này được xây dựng nhằm phục vụ cho:

- Sinh viên học cấu trúc dữ liệu và giải thuật
- Ôn tập phỏng vấn kỹ thuật
- Lập trình thi đấu
- Luyện tập khả năng lập trình thủ công thuật toán

## 👨‍💻 Tác giả

- **Thilin Nandun** – [Hồ sơ GitHub](https://github.com/thilinnd)

## 🌟 Ủng hộ dự án

Nếu bạn thấy thư viện hữu ích, hãy ⭐ repo này và chia sẻ đến bạn bè nhé!
