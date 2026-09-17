package com.kwad.sdk.core.j;

/* JADX INFO: loaded from: classes3.dex */
public abstract class b implements c {
    private boolean bbU = false;
    private boolean abi = false;
    private boolean abj = false;

    protected abstract void aM();

    protected abstract void aN();

    @Override // com.kwad.sdk.core.j.c
    public final void bv() {
        this.bbU = true;
        if (this.abj) {
            return;
        }
        aM();
        this.abj = true;
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bw() {
        if (this.bbU && !this.abi) {
            aN();
            this.abi = true;
        }
    }
}
