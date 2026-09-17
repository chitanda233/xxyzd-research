package com.czhj.sdk.common.utils;

import android.content.ComponentName;
import android.content.Context;
import android.content.ServiceConnection;
import android.os.IBinder;
import android.os.IInterface;
import android.os.Looper;
import android.os.RemoteException;
import com.czhj.sdk.logger.SigmobLog;
import java.util.concurrent.LinkedBlockingQueue;

/* JADX INFO: loaded from: classes2.dex */
public class PlayServicesUtil {

    private static final class AdvertisingConnection implements ServiceConnection {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        boolean f2295a;
        private final LinkedBlockingQueue<IBinder> b;

        private AdvertisingConnection() {
            this.f2295a = false;
            this.b = new LinkedBlockingQueue<>(1);
        }

        IBinder a() throws InterruptedException {
            if (this.f2295a) {
                throw new IllegalStateException();
            }
            this.f2295a = true;
            return this.b.take();
        }

        @Override // android.content.ServiceConnection
        public void onServiceConnected(ComponentName componentName, IBinder iBinder) {
            try {
                this.b.put(iBinder);
            } catch (Throwable th) {
                SigmobLog.e(th.getMessage());
            }
        }

        @Override // android.content.ServiceConnection
        public void onServiceDisconnected(ComponentName componentName) {
        }
    }

    public static class AdvertisingInfo {
        public final String advertisingId;
        public final boolean limitAdTracking;

        AdvertisingInfo(String str, boolean z) {
            this.advertisingId = str;
            this.limitAdTracking = z;
        }
    }

    private static final class AdvertisingInterface implements IInterface {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private final IBinder f2296a;

        AdvertisingInterface(IBinder iBinder) {
            this.f2296a = iBinder;
        }

        String a() throws RemoteException {
            return null;
        }

        @Override // android.os.IInterface
        public IBinder asBinder() {
            return this.f2296a;
        }

        boolean b() throws RemoteException {
            return false;
        }
    }

    public static AdvertisingInfo getAdvertisingIdInfo(Context context) throws Exception {
        Looper.myLooper();
        Looper.getMainLooper();
        return null;
    }
}
