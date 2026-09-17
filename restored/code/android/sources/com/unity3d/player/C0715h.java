package com.unity3d.player;

import android.os.Handler;
import android.os.Looper;
import com.google.android.play.core.assetpacks.AssetPackState;
import com.google.android.play.core.assetpacks.AssetPackStateUpdateListener;
import java.util.HashSet;
import java.util.Set;

/* JADX INFO: renamed from: com.unity3d.player.h, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes4.dex */
final class C0715h implements AssetPackStateUpdateListener {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private HashSet f4044a;
    private Looper b;
    final /* synthetic */ C0727n c;

    public C0715h(C0727n c0727n, IAssetPackManagerDownloadStatusCallback iAssetPackManagerDownloadStatusCallback, Looper looper) {
        this.c = c0727n;
        HashSet hashSet = new HashSet();
        this.f4044a = hashSet;
        hashSet.add(iAssetPackManagerDownloadStatusCallback);
        this.b = looper;
    }

    public final synchronized void a(IAssetPackManagerDownloadStatusCallback iAssetPackManagerDownloadStatusCallback) {
        this.f4044a.add(iAssetPackManagerDownloadStatusCallback);
    }

    public final void onStateUpdate(Object obj) {
        AssetPackState assetPackState = (AssetPackState) obj;
        synchronized (this) {
            if (assetPackState.status() == 4 || assetPackState.status() == 5 || assetPackState.status() == 0) {
                synchronized (C0727n.d) {
                    this.c.b.remove(assetPackState.name());
                    if (this.c.b.isEmpty()) {
                        C0727n c0727n = this.c;
                        c0727n.a(c0727n.c);
                        this.c.c = null;
                    }
                }
            }
            if (this.f4044a.size() != 0) {
                new Handler(this.b).post(new RunnableC0713g((Set) this.f4044a.clone(), assetPackState.name(), assetPackState.status(), assetPackState.totalBytesToDownload(), assetPackState.bytesDownloaded(), assetPackState.transferProgressPercentage(), assetPackState.errorCode()));
            }
        }
    }
}
