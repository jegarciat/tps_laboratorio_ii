using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface IArchivo<T>
    {
        /// <summary>
        /// Exporta un objeto del tipo T en un archivo en la ruta pasada por parámetro.
        /// </summary>
        /// <param name="nombreArchivo">String donde se creara el archivo</param>
        /// <param name="info">Objeto T con la informacion a guardar en el archivo</param>
        /// <returns>Retorna true si se pudo guardar, falso en caso contrario.</returns>
        bool Exportar(string nombreArchivo, T info);

        /// <summary>
        /// Lee un archivo en la ruta pasada por parámetro.
        /// </summary>
        /// <param name="nombreArchivo">String de donde se leera el archivo</param>
        /// <returns>Retorna el objeto leído</returns>
        T Importar(string nombreArchivo);
    }
}
