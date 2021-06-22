# <img src="https://github.com/kitpymes/template-netcore-repositories/raw/master/docs/images/logo.png" height="30px"> Kitpymes.Core.Repositories

**Repositorios para acceder a las bases de datos**

[![Build Status](https://github.com/kitpymes/template-netcore-repositories/workflows/Kitpymes.Core.Repositories/badge.svg)](https://github.com/kitpymes/template-netcore-repositories/actions)
[![NuGet Status](https://img.shields.io/nuget/v/Kitpymes.Core.Repositories)](https://www.nuget.org/packages/Kitpymes.Core.Repositories/)
[![NuGet Download](https://img.shields.io/nuget/dt/Kitpymes.Core.Repositories)](https://www.nuget.org/stats/packages/Kitpymes.Core.Repositories?groupby=Version)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://github.com/kitpymes/template-netcore-repositories/blob/master/docs/LICENSE.txt)
[![Size Repo](https://img.shields.io/github/repo-size/kitpymes/template-netcore-repositories)](https://github.com/kitpymes/template-netcore-repositories/)
[![Last Commit](https://img.shields.io/github/last-commit/kitpymes/template-netcore-repositories)](https://github.com/kitpymes/template-netcore-repositories/)

## 📋 Requerimientos 

* Visual Studio >= 2019

* NET TargetFramework >= net5.0

* Net Core SDK >= 5.0.100

* C# >= 9.0

* Conocimientos sobre Inyección de Dependencias

## 🔧 Instalación 

_Se puede instalar usando el administrador de paquetes Nuget o CLI dotnet._

_Nuget_

```
Install-Package Kitpymes.Core.Repositories
```

_CLI dotnet_

```
dotnet add package Kitpymes.Core.Repositories
```

## ⌨️ Código

### Commands

```cs
public interface ICommandRepository<T>
        where T : class
    {
        void Add(T item);

        Task AddAsync(T item);

        void AddRange(IEnumerable<T> items);

        Task AddRangeAsync(IEnumerable<T> items);

        void Update(object key, T item);

        Task UpdateAsync(object key, T item);

        void UpdatePartial(object key, object item);

        Task UpdatePartialAsync(object key, object item);

        void Delete(object key);

        Task DeleteAsync(object key);

        void Delete(Expression<Func<T, bool>> where);

        Task DeleteAsync(Expression<Func<T, bool>> where);
    }
```

```cs
public interface ICommandRelationalRepository<T> : ICommandRepository<T>
    where T : class { }
```

### Queries

```cs
 public interface IQueryRepository<T>
        where T : class
{
    T GetOne(Expression<Func<T, bool>> where);

    Task<T> GetOneAsync(Expression<Func<T, bool>> where);

    IEnumerable<T> GetAll();

    Task<IEnumerable<T>> GetAllAsync();

    IEnumerable<T> GetAll(Expression<Func<T, bool>> where);

    Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> where);

    IEnumerable<T> GetPaged(Action<(string? property, bool? ascending, int? index, int? size)> parameters);

    Task<IEnumerable<T>> GetPagedAsync(Action<(string? property, bool? ascending, int? index, int? size)> parameters);

    T Find(object key);

    Task<T> FindAsync(object key);

    bool Any();

    Task<bool> AnyAsync();

    bool Any(Expression<Func<T, bool>> where);

    Task<bool> AnyAsync(Expression<Func<T, bool>> where);

    long Count();

    Task<long> CountAsync();

    long Count(Expression<Func<T, bool>> where);

    Task<long> CountAsync(Expression<Func<T, bool>> where);
}
```

### IUnitOfWork

```cs
public interface IUnitOfWork
{
    void OpenTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted);

    void Save();
}
```

```cs
public interface IRepository<T> : ICommandRepository<T>, IQueryRepository<T>
    where T : class { }
```

```cs
public interface IRelationalRepository<T> : IRepository<T>, ICommandRelationalRepository<T>, IQueryRelationalRepository<T>
    where T : class { }
```

## ⚙️ Pruebas Unitarias

_No son necesarias porque son interfaces, las pruebas serán realizadas en su implementación_


## 🛠️ Construido con 

* [NET Core](https://dotnet.microsoft.com/download) - Framework de trabajo
* [C#](https://docs.microsoft.com/es-es/dotnet/csharp/) - Lenguaje de programación
* [Inserción de dependencias](https://docs.microsoft.com/es-es/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-3.0) - Patrón de diseño de software
* [MSTest](https://docs.microsoft.com/es-es/dotnet/core/testing/unit-testing-with-mstest) - Pruebas unitarias
* [Nuget](https://www.nuget.org/) - Manejador de dependencias
* [Visual Studio](https://visualstudio.microsoft.com/) - Entorno de programacion


## ✒️ Autores 

* **Sebastian R Ferrari** - *Trabajo Inicial* - [kitpymes](https://kitpymes.com)


## 📄 Licencia 

* Este proyecto está bajo la Licencia [LICENSE](LICENSE.txt)


## 🎁 Gratitud 

* Este proyecto fue diseñado para compartir, creemos que es la mejor forma de ayudar 📢
* Cada persona que contribuya sera invitada a tomar una 🍺 
* Gracias a todos! 🤓

---
[Kitpymes](https://github.com/kitpymes) 😊