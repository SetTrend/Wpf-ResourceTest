namespace ExternalTheme
{
	/* Um Ressourcen über Assemblies hinweg teilen zu können, ist eine Klasse notwendig,
	 * mit dessen Hilfe der Pfad zur Ressouce von WPF erstellt werden kann.
	 * Dies kann eine beliebige Klasse sein.
	 * Es geht hier nur um ein Mittel zur automatischen Erzeugung einer eindeutigen Referenz-ID.
	 * Die Klasse muss "public" definiert sein, damit sie von der anderen Assembly gefunden werden kann.
	 */
	public abstract class DummyForSharingResources
	{
		//static public ComponentResourceKey TestImg = new ComponentResourceKey(typeof(DummyForSharingResources), "TestImg");
		//static public ComponentResourceKey TestBg = new ComponentResourceKey(typeof(DummyForSharingResources), "TestBg");
	}
}
