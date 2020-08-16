// -----------------------------------------------------------------------
// <copyright file="IUnitOfWork.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Repositories
{
    using System.Data;

    /*
        Unidad de trabajo para bases de datos
        Contiene las acciones comunes a todos los repositorios
    */

    /// <summary>
    /// Unidad de trabajo para bases de datos <c>IUnitOfWork</c>.
    /// Contiene las acciones comunes a todos los repositorios.
    /// </summary>
    /// <remarks>
    /// <para>En esta interfaz se pueden agregar todas las acciones comunes a todos los repositorios.</para>
    /// </remarks>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Abrir una conexión a una bade de datos.
        /// </summary>
        /// <param name="isolationLevel">Especifica el comportamiento de bloqueo de transacciones para la conexión.</param>
        void OpenTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted);

        /// <summary>
        /// Guardar en la bade de datos.
        /// </summary>
        void Save();
    }
}
