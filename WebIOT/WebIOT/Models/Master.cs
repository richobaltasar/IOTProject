﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebIOT.Models
{
    public class FormMasterData
    {
        public List<FormMaster> Template { get; set; }
        public dynamic dbContext { get; set; }
        public string classNameWithNameSpace { get; set; }
        public string ShowSubmit { get; set; }
        public int ColField { get; set; }
    }
    public class FormMaster
    {
        public string idLog { get; set; }
        public string NamaForm { get; set; }
        public string Type { get; set; }
        public string Id { get; set; }
        public string TextLabel { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string ValueInput { get; set; }
        public string ListModel { get; set; }
        public string Urutan { get; set; }
        public string ShowHide { get; set; }
        public string ReadOnly { get; set; }
        public string Enable { get; set; }
        public string Mandatory { get; set; }
        public string IsNumber { get; set; }
        public string FilterBy { get; set; }


    }
    #region Module Data

    public class ModuleDataModel
    {
        public List<ModuleData> ListData { get; set; }
        public ErrorViewModel Error { get; set; }
    }
    public class ModuleData
    {
        public int IdModul { get; set; }
        public string NamaModule { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string Img { get; set; }
        public int Status { get; set; }

        public IFormFile File_Img { get; set; }
        public ErrorViewModel Error { get; set; }
    }

    #endregion

    #region Menu Data
    public class MenuDataModel
    {
        public List<MenuData> ListData { get; set; }
        public ErrorViewModel Error { get; set; }
    }
    public class MenuData
    {
        public int idMenu { get; set; }
        public string NamaMenu { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string Platform { get; set; }
        public string Img { get; set; }
        public int Status { get; set; }

        public IFormFile File_Img { get; set; }
        public ErrorViewModel Error { get; set; }
    }
    #endregion

    #region FormData
    public class FormDataModel
    {
        public List<FormData> ListData { get; set; }
        public ErrorViewModel Error { get; set; }
    }
    public class FormData
    {
        public int idLog { get; set; }
        public string NamaForm { get; set; }
        public string Type { get; set; }
        public string Id { get; set; }
        public string TextLabel { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string ValueInput { get; set; }
        public string ListModel { get; set; }
        public int Urutan { get; set; }
        public string ShowHide { get; set; }
        public string ReadOnly { get; set; }
        public string Enable { get; set; }
        public string Mandatory { get; set; }
        public int IsNumber { get; set; }
        public int FilterBy { get; set; }

        public ErrorViewModel Error { get; set; }
    }
    #endregion

    #region ListItemData
    public class ListItemDataModel
    {
        public List<ListItemData> ListData { get; set; }
        public ErrorViewModel Error { get; set; }
    }
    public class ListItemData
    {
        public int id { get; set; }
        public string ListName { get; set; }
        public string Urutan { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }

        public ErrorViewModel Error { get; set; }
    }
    #endregion

    #region RoleMenuData
    public class RoleMenuDataModel
    {
        public List<RoleMenuData> ListData { get; set; }
        public ErrorViewModel Error { get; set; }
    }
    public class RoleMenuData
    {
        public int IdRole { get; set; }

        public int IdModule { get; set; }
        public string NamaModule { get; set; }

        public int IdMenu { get; set; }
        public string NamaMenu { get; set; }

        public int Posisi { get; set; }
        public string NamaPosisi { get; set; }

        public int IdParent { get; set; }
        public string NamaParent { get; set; }

        public string Platform { get; set; }

        public int Urutan { get; set; }
        

        public ErrorViewModel Error { get; set; }
    }
    #endregion

    #region RoleGroupAkses
    public class RoleGroupAkses
    {
        public int IdRole { get; set; }
        public string NamaGroup { get; set; }
        public string Desc { get; set; }
        public int Status { get; set; }
        public ErrorViewModel Error { get; set; }
    }
    public class RoleGroupAksesModel
    {
        public List<RoleGroupAkses> ListData { get; set; }
        public ErrorViewModel Error { get; set; }
    }

    public class RoleGroupAkses_ListMenu_Model
    {
        public RoleGroupAkses Data { get; set; }
        public List<MenuData> ListMenu { get; set; }
        public ErrorViewModel Error { get; set; }
    }


    public class GroupData_MenuAkses
    {
        public int IdRole { get; set; }
        public int IdMenu { get; set; }

    }


    #endregion

    #region Master Buku
    public class BukuData
    {
        public int IdBook { get; set; }
        public string JudulBuku { get; set; }
        public string Pengarang { get; set; }
        public string JenisBuku { get; set; }
        public string HargaSewaPerHari { get; set; }
        public int Status { get; set; }

        public string Img { get; set; }
        public IFormFile File_Img { get; set; }

        public ErrorViewModel Error { get; set; }

    }
    public class BukuDataModel
    {
        public List<BukuData> ListData { get; set; }
        public ErrorViewModel Error { get; set; }
    }

    public class CariBuku
    {
        public string AllText { get; set; }
        public string JudulBuku { get; set; }
        public string Pengarang { get; set; }
        public string JenisBuku { get; set; }
        public ErrorViewModel Error { get; set; }

    }

    public class FormPeminjamanBuku
    {
        public int IdBook { get; set; }
        public string JudulBuku { get; set; }
        public string Pengarang { get; set; }
        public string JenisBuku { get; set; }
        public string HargaSewaPerHari { get; set; }
        public string Img { get; set; }
        public int Status { get; set; }

        public string SewaDari { get; set; }
        public string Sewasampai { get; set; }
        public string TotalSewa { get; set; }
        public string IdUser_Penyewa { get; set; }
        
        public ErrorViewModel Error { get; set; }
    }

    public class CariBukuModel
    {
        public CariBuku Search { get; set; }
        public List<BukuData> DataBuku { get; set; }
        public FormPeminjamanBuku FormPeminjaman { get; set; }

        public ErrorViewModel Error { get; set; }
    }
    #endregion
}
