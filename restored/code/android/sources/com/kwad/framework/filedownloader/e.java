package com.kwad.framework.filedownloader;

import com.kwad.framework.filedownloader.event.DownloadServiceConnectChangedEvent;

/* JADX INFO: loaded from: classes3.dex */
public abstract class e extends com.kwad.framework.filedownloader.event.c {
    private DownloadServiceConnectChangedEvent.ConnectStatus azI;

    public abstract void Bu();

    public abstract void Bv();

    @Override // com.kwad.framework.filedownloader.event.c
    public final boolean a(com.kwad.framework.filedownloader.event.b bVar) {
        if (!(bVar instanceof DownloadServiceConnectChangedEvent)) {
            return false;
        }
        DownloadServiceConnectChangedEvent.ConnectStatus connectStatusCR = ((DownloadServiceConnectChangedEvent) bVar).CR();
        this.azI = connectStatusCR;
        if (connectStatusCR == DownloadServiceConnectChangedEvent.ConnectStatus.connected) {
            Bu();
            return false;
        }
        Bv();
        return false;
    }

    public final DownloadServiceConnectChangedEvent.ConnectStatus Bw() {
        return this.azI;
    }
}
