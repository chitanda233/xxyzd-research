package com.kwad.library.b.c;

import android.app.Application;
import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.ServiceConnection;
import android.content.res.AssetManager;
import android.content.res.Resources;
import android.os.Bundle;
import com.kwad.sdk.utils.ab;

/* JADX INFO: loaded from: classes3.dex */
final class a extends Application implements d {
    private final String TAG = "PluginApplicationWrapper";
    private final Application aDT;
    private b aDU;
    private String aDV;

    public a(Application application, String str) {
        this.aDT = application;
        this.aDV = str;
        b bVar = new b(application, this.aDV);
        this.aDU = bVar;
        try {
            ab.b(this, "mBase", bVar);
        } catch (Throwable unused) {
            attachBaseContext(this.aDU);
        }
    }

    @Override // com.kwad.library.b.c.d
    public final Context getDelegatedContext() {
        return this.aDT;
    }

    @Override // android.content.ContextWrapper, android.content.Context
    public final Context getApplicationContext() {
        try {
            Context contextM = c.m(this.aDT, this.aDV);
            new StringBuilder("PluginApplicationWrapper getApplicationContext result:  ").append(contextM);
            return contextM;
        } catch (Throwable th) {
            com.kwad.library.solder.lib.a.e("PluginApplicationWrapper", "PluginApplicationWrapper getApplicationContext error:  ", th);
            th.printStackTrace();
            return null;
        }
    }

    @Override // android.content.ContextWrapper, android.content.Context
    public final Resources getResources() {
        return this.aDU.getResources();
    }

    @Override // android.content.ContextWrapper, android.content.Context
    public final AssetManager getAssets() {
        return this.aDU.getAssets();
    }

    @Override // android.content.ContextWrapper, android.content.Context
    public final ClassLoader getClassLoader() {
        return this.aDU.getClassLoader();
    }

    @Override // android.content.ContextWrapper, android.content.Context
    public final void startActivity(Intent intent) {
        this.aDT.startActivity(intent);
    }

    @Override // android.content.ContextWrapper, android.content.Context
    public final void startActivities(Intent[] intentArr) {
        this.aDT.startActivities(intentArr);
    }

    @Override // android.content.ContextWrapper, android.content.Context
    public final void startActivity(Intent intent, Bundle bundle) {
        this.aDT.startActivity(intent, bundle);
    }

    @Override // android.content.ContextWrapper, android.content.Context
    public final void startActivities(Intent[] intentArr, Bundle bundle) {
        this.aDT.startActivities(intentArr, bundle);
    }

    @Override // android.content.ContextWrapper, android.content.Context
    public final ComponentName startForegroundService(Intent intent) {
        return this.aDT.startForegroundService(intent);
    }

    @Override // android.content.ContextWrapper, android.content.Context
    public final void sendBroadcast(Intent intent) {
        this.aDT.sendBroadcast(intent);
    }

    @Override // android.content.ContextWrapper, android.content.Context
    public final boolean bindService(Intent intent, ServiceConnection serviceConnection, int i) {
        return this.aDT.bindService(intent, serviceConnection, i);
    }

    @Override // android.content.ContextWrapper, android.content.Context
    public final void unbindService(ServiceConnection serviceConnection) {
        this.aDT.unbindService(serviceConnection);
    }

    @Override // android.content.ContextWrapper, android.content.Context
    public final void setTheme(int i) {
        this.aDT.setTheme(i);
    }

    @Override // android.content.ContextWrapper, android.content.Context
    public final ComponentName startService(Intent intent) {
        return this.aDT.startService(intent);
    }

    @Override // android.content.ContextWrapper, android.content.Context
    public final boolean stopService(Intent intent) {
        return this.aDT.stopService(intent);
    }

    @Override // android.app.Application
    public final void registerActivityLifecycleCallbacks(Application.ActivityLifecycleCallbacks activityLifecycleCallbacks) {
        this.aDT.registerActivityLifecycleCallbacks(activityLifecycleCallbacks);
    }

    @Override // android.app.Application
    public final void unregisterActivityLifecycleCallbacks(Application.ActivityLifecycleCallbacks activityLifecycleCallbacks) {
        this.aDT.unregisterActivityLifecycleCallbacks(activityLifecycleCallbacks);
    }
}
