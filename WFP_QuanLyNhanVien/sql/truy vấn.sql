SELECT        
 Mã_Xe_Máy, 
 Tên_Xe_Máy, 
 Năm_Sản_Xuất, 
 Dung_Tích_Xăng, 
 Mã_Màu, 
 Ảnh,
 Phái,
 (CASE WHEN Phái = 1 THEN N'Nam' ELSE N'Nữ' END) AS Phái_text
FROM Xe_Máy