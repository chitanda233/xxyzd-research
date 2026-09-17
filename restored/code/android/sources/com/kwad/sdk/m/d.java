package com.kwad.sdk.m;

import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class d extends com.kwad.sdk.core.response.a.a {
    public List<com.kwad.sdk.m.a.a> bmI;
    public List<String> bmQ;
    public List<a> bmR;
    public List<com.kwad.sdk.m.a.b> bmS;
    public long funcSwitch;
    public long byteCount = 1000;
    public double sampleRate = 1.0d;

    public static class a extends com.kwad.sdk.core.response.a.a {
        public String bmT;
        public String bmU;
    }

    public final boolean TT() {
        return (this.funcSwitch & 1) == 0;
    }

    public final boolean TU() {
        return fC(4);
    }

    public final boolean TV() {
        return fC(16);
    }

    public final boolean TW() {
        return fC(32);
    }

    private boolean fC(int i) {
        return (TT() || (this.funcSwitch & ((long) i)) == 0) ? false : true;
    }
}
