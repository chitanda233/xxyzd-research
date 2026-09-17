package com.kwad.framework.filedownloader;

import android.content.Context;
import android.content.Intent;
import com.kwad.framework.filedownloader.event.DownloadServiceConnectChangedEvent;
import com.kwad.sdk.api.proxy.app.FileDownloadService;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
final class o implements com.kwad.framework.filedownloader.services.e.a, u {
    private static Class<?> aAc;
    private final ArrayList<Runnable> aAd = new ArrayList<>();
    private com.kwad.framework.filedownloader.services.e aAe;

    o() {
    }

    private static Class<?> BN() {
        if (aAc == null) {
            aAc = FileDownloadService.SharedMainProcessService.class;
        }
        return aAc;
    }

    @Override // com.kwad.framework.filedownloader.u
    public final boolean a(String str, String str2, boolean z, int i, int i2, int i3, boolean z2, com.kwad.framework.filedownloader.d.b bVar, boolean z3) {
        if (!isConnected()) {
            return com.kwad.framework.filedownloader.f.a.h(str, str2, z);
        }
        this.aAe.b(str, str2, z, i, i2, i3, z2, bVar, z3);
        return true;
    }

    @Override // com.kwad.framework.filedownloader.u
    public final boolean cl(int i) {
        if (!isConnected()) {
            return com.kwad.framework.filedownloader.f.a.cl(i);
        }
        return this.aAe.cl(i);
    }

    @Override // com.kwad.framework.filedownloader.u
    public final byte cm(int i) {
        if (!isConnected()) {
            return com.kwad.framework.filedownloader.f.a.cm(i);
        }
        return this.aAe.cm(i);
    }

    @Override // com.kwad.framework.filedownloader.u
    public final boolean isConnected() {
        return this.aAe != null;
    }

    @Override // com.kwad.framework.filedownloader.u
    public final void aV(Context context) {
        a(context, null);
    }

    private void a(Context context, Runnable runnable) {
        context.startService(new Intent(context, BN()));
    }

    @Override // com.kwad.framework.filedownloader.u
    public final boolean cn(int i) {
        if (!isConnected()) {
            return com.kwad.framework.filedownloader.f.a.cn(i);
        }
        return this.aAe.cn(i);
    }

    @Override // com.kwad.framework.filedownloader.services.e.a
    public final void a(com.kwad.framework.filedownloader.services.e eVar) {
        this.aAe = eVar;
        List list = (List) this.aAd.clone();
        this.aAd.clear();
        Iterator it = list.iterator();
        while (it.hasNext()) {
            ((Runnable) it.next()).run();
        }
        f.Bx().c(new DownloadServiceConnectChangedEvent(DownloadServiceConnectChangedEvent.ConnectStatus.connected, BN()));
    }

    @Override // com.kwad.framework.filedownloader.services.e.a
    public final void onDisconnected() {
        this.aAe = null;
        f.Bx().c(new DownloadServiceConnectChangedEvent(DownloadServiceConnectChangedEvent.ConnectStatus.disconnected, BN()));
    }
}
