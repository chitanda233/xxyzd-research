package a.a.b;

import android.content.ComponentName;
import android.content.Context;
import android.content.ServiceConnection;
import android.os.IBinder;
import android.os.RemoteException;

/* JADX INFO: loaded from: classes.dex */
public class b implements c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public Context f14a;
    public a.a.a.a b;
    public d c;
    public ServiceConnection d = new a();

    public class a implements ServiceConnection {
        public a() {
        }

        @Override // android.content.ServiceConnection
        public void onServiceConnected(ComponentName componentName, IBinder iBinder) {
            b.this.b = a.a.a.a.AbstractBinderC0000a.a(iBinder);
            b.this.c.connectSuccess(true);
        }

        @Override // android.content.ServiceConnection
        public void onServiceDisconnected(ComponentName componentName) {
            b.this.b = null;
        }
    }

    public b(Context context) {
        this.f14a = context;
    }

    public boolean a() {
        boolean zIsSupported;
        a.a.a.a aVar = this.b;
        if (aVar != null) {
            try {
                zIsSupported = aVar.isSupported();
            } catch (RemoteException e) {
                String str = "isSupported exception:" + e.getMessage();
                e.printStackTrace();
                zIsSupported = false;
            }
        } else {
            zIsSupported = false;
        }
        String str2 = "isSupported:" + this.b;
        String str3 = "isSupported ret:" + zIsSupported;
        return zIsSupported;
    }
}
