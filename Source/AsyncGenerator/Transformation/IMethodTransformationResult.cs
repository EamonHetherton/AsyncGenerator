﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsyncGenerator.Analyzation;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AsyncGenerator.Transformation
{
	public interface IMethodTransformationResult : IMemberTransformationResult
	{
		IMethodAnalyzationResult AnalyzationResult { get; }

		/// <summary>
		/// The transformed method
		/// </summary>
		MethodDeclarationSyntax Transformed { get; }
	}
}