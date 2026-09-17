package com.kwad.sdk.ip.direct;

/* JADX INFO: loaded from: classes3.dex */
public final class c implements Comparable<c> {
    private String ip;
    private boolean success;
    private int weight;
    private float bhp = -1.0f;
    private int bhv = 20;
    private int bhu = 3;
    private StringBuffer bhw = new StringBuffer();

    public c(String str) {
        this.ip = str;
    }

    public final String toString() {
        return "PingNetEntity{ip='" + this.ip + "', pingCount=" + this.bhu + ", pingWaitTime=" + this.bhv + ", pingTime='" + this.bhp + " ms', success=" + this.success + '}';
    }

    public final int RI() {
        return this.bhu;
    }

    public final String getIp() {
        return this.ip;
    }

    public final boolean isSuccess() {
        return this.success;
    }

    public final void cb(boolean z) {
        this.success = z;
    }

    public final float RJ() {
        return this.bhp;
    }

    public final void r(float f) {
        this.bhp = f;
    }

    public final int getWeight() {
        return this.weight;
    }

    public final void eR(int i) {
        this.weight = i;
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // java.lang.Comparable
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public int compareTo(c cVar) {
        return (int) (this.bhp - cVar.bhp);
    }
}
