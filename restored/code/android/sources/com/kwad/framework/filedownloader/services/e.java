package com.kwad.framework.filedownloader.services;

import android.app.Notification;
import android.os.IBinder;
import com.kwad.framework.filedownloader.n;
import java.lang.ref.WeakReference;

/* JADX INFO: loaded from: classes3.dex */
public final class e extends com.kwad.framework.filedownloader.c.b.a implements i {
    private final g aDg;
    private final WeakReference<FileDownloadServiceProxy> aDh;

    public interface a {
        void a(e eVar);

        void onDisconnected();
    }

    @Override // com.kwad.framework.filedownloader.services.i
    public final IBinder DA() {
        return null;
    }

    @Override // com.kwad.framework.filedownloader.c.b
    public final void a(com.kwad.framework.filedownloader.c.a aVar) {
    }

    @Override // com.kwad.framework.filedownloader.c.b
    public final void b(com.kwad.framework.filedownloader.c.a aVar) {
    }

    e(WeakReference<FileDownloadServiceProxy> weakReference, g gVar) {
        this.aDh = weakReference;
        this.aDg = gVar;
    }

    @Override // com.kwad.framework.filedownloader.c.b
    public final boolean y(String str, String str2) {
        return this.aDg.A(str, str2);
    }

    @Override // com.kwad.framework.filedownloader.c.b
    public final void b(String str, String str2, boolean z, int i, int i2, int i3, boolean z2, com.kwad.framework.filedownloader.d.b bVar, boolean z3) {
        this.aDg.b(str, str2, z, i, i2, i3, z2, bVar, z3);
    }

    @Override // com.kwad.framework.filedownloader.c.b
    public final boolean cl(int i) {
        return this.aDg.cl(i);
    }

    @Override // com.kwad.framework.filedownloader.c.b
    public final void pauseAllTasks() {
        this.aDg.DC();
    }

    @Override // com.kwad.framework.filedownloader.c.b
    public final boolean cF(int i) {
        return this.aDg.cF(i);
    }

    @Override // com.kwad.framework.filedownloader.c.b
    public final long cG(int i) {
        return this.aDg.cR(i);
    }

    @Override // com.kwad.framework.filedownloader.c.b
    public final long cH(int i) {
        return this.aDg.cH(i);
    }

    @Override // com.kwad.framework.filedownloader.c.b
    public final byte cm(int i) {
        return this.aDg.cm(i);
    }

    @Override // com.kwad.framework.filedownloader.c.b
    public final boolean isIdle() {
        return this.aDg.isIdle();
    }

    @Override // com.kwad.framework.filedownloader.c.b
    public final void startForeground(int i, Notification notification) {
        WeakReference<FileDownloadServiceProxy> weakReference = this.aDh;
        if (weakReference == null || weakReference.get() == null) {
            return;
        }
        this.aDh.get().context.startForeground(i, notification);
    }

    @Override // com.kwad.framework.filedownloader.c.b
    public final void stopForeground(boolean z) {
        WeakReference<FileDownloadServiceProxy> weakReference = this.aDh;
        if (weakReference == null || weakReference.get() == null) {
            return;
        }
        this.aDh.get().context.stopForeground(z);
    }

    @Override // com.kwad.framework.filedownloader.c.b
    public final boolean cn(int i) {
        return this.aDg.cn(i);
    }

    @Override // com.kwad.framework.filedownloader.c.b
    public final void CT() {
        this.aDg.CT();
    }

    @Override // com.kwad.framework.filedownloader.services.i
    public final void Dz() {
        n.BL().a(this);
    }

    @Override // com.kwad.framework.filedownloader.services.i
    public final void onDestroy() {
        n.BL().onDisconnected();
    }
}
