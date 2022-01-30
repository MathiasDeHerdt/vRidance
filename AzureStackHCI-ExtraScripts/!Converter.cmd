SET vmdkFilePath="C:\Users\mathias\Downloads\MDH-TestVM_files\MDH-TestVM.vmdk"
SET vhdFilePath="C:\Users\mathias\Documents\VHD-Conv\conv.vhd"

V2V_ConverterConsole.exe convert in_file_name=%vmdkFilePath% out_file_name=%vhdFilePath% out_file_type=ft_vhd_thin