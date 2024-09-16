using System;

namespace Project24_Interface.Interface;

public interface IRepo // abstract classlardaki gibi abstract diye belirtmek zorunda olmadan miras verdiğim yerde içine yazdığım metotları direkt zorunlu hale getiriyorum. İçinde sadece normalde abstract metodları içerecek bir şey yazacaksak.
{
    public void Create();
    public void GetAll();
    public void GetById();
    public void Update();
    public void Delete();

    public void GetByUrl();

}
