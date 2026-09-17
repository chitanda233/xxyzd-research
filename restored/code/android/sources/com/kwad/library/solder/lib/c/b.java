package com.kwad.library.solder.lib.c;

import java.util.HashMap;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class b implements Comparable<b> {
    public String aEW;
    public boolean aEX;
    public List<String> aFA;
    public List<String> aFB;
    public ClassLoader aFC;
    public String aFt;
    public String aFu;
    public long aFv;
    public String aFw;
    public boolean aFx = false;
    public boolean aFy = true;
    public HashMap<String, String> aFz = new HashMap<>(10);
    public boolean enable;
    public String version;

    /* JADX INFO: Access modifiers changed from: private */
    @Override // java.lang.Comparable
    /* JADX INFO: renamed from: b, reason: merged with bridge method [inline-methods] */
    public int compareTo(b bVar) {
        return -this.version.compareTo(bVar.version);
    }

    public final String toString() {
        return "RemotePluginInfo{pluginId='" + this.aFt + "', version='" + this.version + "', downloadUrl='" + this.aFu + "', fileSize=" + this.aFv + ", enable=" + this.enable + ", md5sum='" + this.aFw + "', onlyWifiDownload=" + this.aFx + ", onlyWifiRetryDownload=" + this.aFy + ", soMd5s=" + this.aFz + ", hostPackages=" + this.aFA + ", hostInterfaces=" + this.aFB + '}';
    }
}
