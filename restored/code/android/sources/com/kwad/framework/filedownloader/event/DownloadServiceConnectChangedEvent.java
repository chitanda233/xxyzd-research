package com.kwad.framework.filedownloader.event;

/* JADX INFO: loaded from: classes3.dex */
public final class DownloadServiceConnectChangedEvent extends b {
    private final ConnectStatus aCp;
    private final Class<?> aCq;

    public enum ConnectStatus {
        connected,
        disconnected,
        lost
    }

    public DownloadServiceConnectChangedEvent(ConnectStatus connectStatus, Class<?> cls) {
        super("event.service.connect.changed");
        this.aCp = connectStatus;
        this.aCq = cls;
    }

    public final ConnectStatus CR() {
        return this.aCp;
    }
}
