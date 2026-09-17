package a.f.b;

import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.ServiceConnection;
import android.os.IBinder;

/* JADX INFO: loaded from: classes.dex */
public class a {
    public a.f.a.a b;
    public ServiceConnection c;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public Context f31a = null;
    public b d = null;

    /* JADX INFO: renamed from: a.f.b.a$a, reason: collision with other inner class name */
    public class ServiceConnectionC0009a implements ServiceConnection {
        public ServiceConnectionC0009a() {
        }

        @Override // android.content.ServiceConnection
        public synchronized void onServiceConnected(ComponentName componentName, IBinder iBinder) {
            a.this.b = a.f.a.a.AbstractBinderC0007a.a(iBinder);
            a aVar = a.this;
            b bVar = aVar.d;
            if (bVar != null) {
                bVar.serviceConnected("Deviceid Service Connected", aVar);
            }
            a.this.getClass();
        }

        @Override // android.content.ServiceConnection
        public void onServiceDisconnected(ComponentName componentName) {
            a.this.b = null;
        }
    }

    public interface b<T> {
        void serviceConnected(T t, a aVar);
    }

    public int a(Context context, b<String> bVar) {
        if (context == null) {
            throw new NullPointerException("Context can not be null.");
        }
        this.f31a = context;
        this.d = bVar;
        this.c = new ServiceConnectionC0009a();
        Intent intent = new Intent();
        intent.setClassName("com.zui.deviceidservice", "com.zui.deviceidservice.DeviceidService");
        return this.f31a.bindService(intent, this.c, 1) ? 1 : -1;
    }
}
