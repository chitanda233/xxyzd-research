package com.volcengine.mobsecBiz.metasec.ml;

import java.util.Map;
import ms.bz.bd.c.Pgl.p0;
import ms.bz.bd.c.Pgl.q0;

/* JADX INFO: loaded from: classes4.dex */
public final class PglMSManager implements q0.pgla {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final q0.pgla f4076a;

    PglMSManager(p0 p0Var) {
        this.f4076a = p0Var;
    }

    @Override // ms.bz.bd.c.Pgl.q0.pgla
    public Map<String, String> getFeatureHash(String str, byte[] bArr) {
        return this.f4076a.getFeatureHash(str, bArr);
    }

    @Override // ms.bz.bd.c.Pgl.q0.pgla
    public String getToken() {
        return this.f4076a.getToken();
    }

    @Override // ms.bz.bd.c.Pgl.q0.pgla
    public void report(String str) {
        this.f4076a.report(str);
    }

    @Override // ms.bz.bd.c.Pgl.q0.pgla
    public void setBDDeviceID(String str) {
        this.f4076a.setBDDeviceID(str);
    }

    @Override // ms.bz.bd.c.Pgl.q0.pgla
    public void setCollectMode(int i) {
        this.f4076a.setCollectMode(i);
    }

    @Override // ms.bz.bd.c.Pgl.q0.pgla
    public void setDeviceID(String str) {
        this.f4076a.setDeviceID(str);
    }

    @Override // ms.bz.bd.c.Pgl.q0.pgla
    public void setInstallID(String str) {
        this.f4076a.setInstallID(str);
    }
}
