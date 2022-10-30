-- int: số nguyên
-- float: số thực
-- nvarchar: chuỗi tiếng Việt có dấu
-- varchar: chuỗi
-- char: kí tự
-- bit: nhị phân 1/0

-- Sửa mã SQL này theo đề tài của nhóm mình
-- Xóa bảng cũ
IF OBJECT_ID(N'Xe_Máy', N'U') IS NOT NULL  
   DROP TABLE Xe_Máy;  
GO

-- Tạo mới bảng
CREATE TABLE Xe_Máy
(
    Mã_Xe_Máy      INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Tên_Xe_Máy     NVARCHAR(150),
    Năm_Sản_Xuất   INT,
    Dung_Tích_Xăng FLOAT,
    Mã_Màu         CHAR,
    Phái           BIT,
    Ảnh            VARCHAR(255),
)
GO

-- Khởi tạo 3 dòng bản ghi ban đầu
INSERT INTO Xe_Máy(Tên_Xe_Máy, Năm_Sản_Xuất, Dung_Tích_Xăng, Mã_Màu, Phái, Ảnh)
VALUES
(N'Suzuki', 2020, 3.7, 'R', 1, 'images\no image.jpg'),
(N'Honda', 2021, 4.8, 'G', 1, 'images\no image.jpg'),
(N'Yamaha', 2022, 5.2, 'B', 0, 'images\no image.jpg')
GO    