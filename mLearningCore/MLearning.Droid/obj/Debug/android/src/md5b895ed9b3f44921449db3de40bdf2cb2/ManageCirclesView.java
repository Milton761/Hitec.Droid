package md5b895ed9b3f44921449db3de40bdf2cb2;


public class ManageCirclesView
	extends md57b8dd31b26d57b878589ceca204f3b49.MvxActivity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("MLearning.Droid.Views.ManageCirclesView, Hitec, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ManageCirclesView.class, __md_methods);
	}


	public ManageCirclesView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ManageCirclesView.class)
			mono.android.TypeManager.Activate ("MLearning.Droid.Views.ManageCirclesView, Hitec, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
