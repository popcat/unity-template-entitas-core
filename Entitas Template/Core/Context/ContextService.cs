﻿using System;
using Entitas;

namespace BartekNizio.EntitasSystem
{
	public class ContextService
	{
		public Action<IContext> onBeforeContextReset;
		public Action<IContext> onContextResetDone;

		public void StartContextReset(IContext context)
		{
			onBeforeContextReset.Invoke( context );
		}

		public void EndContextReset(IContext context)
		{
			context.Reset();
			onContextResetDone.Invoke( context );
		}
	}
}