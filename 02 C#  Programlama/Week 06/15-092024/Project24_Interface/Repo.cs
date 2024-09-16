using System;
using System.Diagnostics.Contracts;

namespace Project24_Interface;
//bu class'ı ileride oluşturucağım Product,Category,Customer gibi farklı yapılar için miras vermek üzere oluşturuyorum. 
public abstract class Repo //içine gövde yazılamyan sadece miras verilecek zorunlu classları belirtmek için bir class oluşturuyorsam bunun yerine ınterface kullanabilirim.
 
{
    public abstract void Create();
    public abstract void GetAll();
    public abstract void GetById();
    public abstract void Update();
    public abstract void Delete();
    
    public abstract void GetByUrl();
}

public class ProductRepo : Repo
{
    public override void Create()
    {
        throw new NotImplementedException();
    }

    public override void Delete()
    {
        throw new NotImplementedException();
    }

    public override void GetAll()
    {
        throw new NotImplementedException();
    }

    public override void GetById()
    {
        throw new NotImplementedException();
    }

    public override void GetByUrl()
    {
        throw new NotImplementedException();
    }

    public override void Update()
    {
        throw new NotImplementedException();
    }
}

public class CategoryRepo : Repo

{
    public override void Create()
    {
        throw new NotImplementedException();
    }

    public override void Delete()
    {
        throw new NotImplementedException();
    }

    public override void GetAll()
    {
        throw new NotImplementedException();
    }

    public override void GetById()
    {
        throw new NotImplementedException();
    }

    public override void GetByUrl()
    {
        throw new NotImplementedException();
    }

    public override void Update()
    {
        throw new NotImplementedException();
    }
}


public class EmployeeRepo : Repo
{
    public override void Create()
    {
        throw new NotImplementedException();
    }

    public override void Delete()
    {
        throw new NotImplementedException();
    }

    public override void GetAll()
    {
        throw new NotImplementedException();
    }

    public override void GetById()
    {
        throw new NotImplementedException();
    }

    public override void GetByUrl()
    {
        throw new NotImplementedException();
    }

    public override void Update()
    {
        throw new NotImplementedException();
    }
}