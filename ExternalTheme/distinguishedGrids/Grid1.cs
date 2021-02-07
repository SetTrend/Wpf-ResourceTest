using System.Windows;
using System.Windows.Controls;

namespace ExternalTheme.distinguishedGrids
{
	/// <summary>
	///		This type of <see cref="Grid"/> is defined here
	///		merely to create a distinguished target type
	///		to be used by styles.
	/// </summary>
	/// <remarks>
	///		I could have used one of the WPF provided controls,
	///		like <see cref="TextBlock"/>, <see cref="Button"/>,
	///		<see cref="Border"/> etc., but I didn't want to deal
	///		with their particular peculiarities. So I created
	///		this <see cref="Grid"/> derived type for simplicity.
	/// </remarks>
	public class Grid1 : Grid
	{
		static Grid1()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(Grid1), new FrameworkPropertyMetadata());
		}
	}
}
