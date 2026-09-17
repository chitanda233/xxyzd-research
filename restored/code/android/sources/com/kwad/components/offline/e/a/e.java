package com.kwad.components.offline.e.a;

import com.kwad.components.offline.api.tk.IOfflineApkLoader;
import com.kwad.components.offline.api.tk.IOfflineApkLoaderHolder;
import com.kwad.sdk.components.k;

/* JADX INFO: loaded from: classes3.dex */
public final class e implements IOfflineApkLoaderHolder {
    private k atl;

    public e(k kVar) {
        this.atl = kVar;
    }

    @Override // com.kwad.components.offline.api.tk.IOfflineApkLoaderHolder
    public final IOfflineApkLoader getApkLoader(int i) {
        return new d(this.atl.bX(i));
    }

    @Override // com.kwad.components.offline.api.tk.IOfflineApkLoaderHolder
    public final IOfflineApkLoader getApkLoader(String str) {
        return new d(this.atl.bM(str));
    }
}
