package com.kwad.framework.filedownloader.services;

import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.ServiceConnection;
import android.os.Binder;
import android.os.IBinder;
import android.os.IInterface;
import android.os.RemoteException;
import com.kwad.framework.filedownloader.event.DownloadServiceConnectChangedEvent;
import com.kwad.framework.filedownloader.u;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public abstract class a<CALLBACK extends Binder, INTERFACE extends IInterface> implements ServiceConnection, u {
    private volatile INTERFACE aCU;
    private final Class<?> aCq;
    private final HashMap<String, Object> aCV = new HashMap<>();
    private final List<Context> aCW = new ArrayList();
    private final ArrayList<Runnable> aAd = new ArrayList<>();
    private final CALLBACK aCT = (CALLBACK) BP();

    protected abstract CALLBACK BP();

    protected abstract void a(INTERFACE r1, CALLBACK callback);

    protected abstract INTERFACE b(IBinder iBinder);

    protected final INTERFACE Do() {
        return this.aCU;
    }

    protected a(Class<?> cls) {
        this.aCq = cls;
    }

    @Override // android.content.ServiceConnection
    public void onServiceConnected(ComponentName componentName, IBinder iBinder) {
        this.aCU = (INTERFACE) b(iBinder);
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(this, "onServiceConnected %s %s", componentName, this.aCU);
        }
        try {
            a(this.aCU, this.aCT);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
        List list = (List) this.aAd.clone();
        this.aAd.clear();
        Iterator it = list.iterator();
        while (it.hasNext()) {
            ((Runnable) it.next()).run();
        }
        com.kwad.framework.filedownloader.f.Bx().c(new DownloadServiceConnectChangedEvent(DownloadServiceConnectChangedEvent.ConnectStatus.connected, this.aCq));
    }

    @Override // android.content.ServiceConnection
    public void onServiceDisconnected(ComponentName componentName) {
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(this, "onServiceDisconnected %s %s", componentName, this.aCU);
        }
        by(true);
    }

    private void by(boolean z) {
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(this, "release connect resources %s", this.aCU);
        }
        this.aCU = null;
        com.kwad.framework.filedownloader.f.Bx().c(new DownloadServiceConnectChangedEvent(DownloadServiceConnectChangedEvent.ConnectStatus.lost, this.aCq));
    }

    @Override // com.kwad.framework.filedownloader.u
    public final void aV(Context context) {
        a(context, (Runnable) null);
    }

    private void a(Context context, Runnable runnable) {
        if (com.kwad.framework.filedownloader.f.f.aY(context)) {
            throw new IllegalStateException("Fatal-Exception: You can't bind the FileDownloadService in :filedownloader process.\n It's the invalid operation and is likely to cause unexpected problems.\n Maybe you want to use non-separate process mode for FileDownloader, More detail about non-separate mode, please move to wiki manually: https://github.com/lingochamp/FileDownloader/wiki/filedownloader.properties");
        }
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(this, "bindStartByContext %s", context.getClass().getSimpleName());
        }
        Intent intent = new Intent(context, this.aCq);
        if (!this.aCW.contains(context)) {
            this.aCW.add(context);
        }
        context.bindService(intent, this, 1);
        context.startService(intent);
    }

    @Override // com.kwad.framework.filedownloader.u
    public final boolean isConnected() {
        return Do() != null;
    }
}
