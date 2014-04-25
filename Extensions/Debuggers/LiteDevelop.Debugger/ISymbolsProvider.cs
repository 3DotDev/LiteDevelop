﻿using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using LiteDevelop.Framework.FileSystem;

namespace LiteDevelop.Debugger
{
    /// <summary>
    /// Provides members for getting member symbols.
    /// </summary>
    public interface ISymbolsProvider
    {
        /// <summary>
        /// Tries to get a function by its original source location.
        /// </summary>
        /// <param name="location">The location of the function to look up.</param>
        /// <param name="token">The token of the function, if available.</param>
        /// <returns><c>True</c> if the token has been found, <c>False</c> otherwise.</returns>
        bool TryGetFunctionByLocation(SourceLocation location, out SymbolToken token);

        /// <summary>
        /// Determines whether a member is generated by the compiler.
        /// </summary>
        /// <param name="token">The token of the member.</param>
        /// <returns><c>True</c> if the member is generated by the compiler, <c>False</c> otherwise.</returns>
        bool IsCompilerGenerated(SymbolToken token);

        /// <summary>
        /// Gets symbols of a specific function.
        /// </summary>
        /// <param name="function">The function to get the symbols from.</param>
        /// <returns>Symbols of the function.</returns>
        IFunctionSymbols GetFunctionSymbols(IFunction function);
    }
}
