package com.byazt.wzi;

import android.app.Service;
import android.content.Intent;
import android.os.Binder;
import android.os.IBinder;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 1656, 2231})
public class BinderPoolService extends Service {
    public Binder c = new c.BinderC0289c();

    @Override // android.app.Service
    public void onCreate() {
        super.onCreate();
    }

    @Override // android.app.Service
    public IBinder onBind(Intent intent) {
        return this.c;
    }

    @Override // android.app.Service
    public void onDestroy() {
        super.onDestroy();
    }
}
