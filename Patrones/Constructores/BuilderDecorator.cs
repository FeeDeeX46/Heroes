using System;

namespace Patrones
{
	public abstract class BuilderDecorator
	{
		BuilderDecorator decorator;
		
		public void DecoratorBuilder(BuilderDecorator decorator)
		{
			this.decorator = decorator;
		}
		
		public BuilderDecorator getDecorator()
		{
			return this.decorator;
		}
		
		public abstract ISector construirDecorator();
	}
}
