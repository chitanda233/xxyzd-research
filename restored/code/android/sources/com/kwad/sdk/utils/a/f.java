package com.kwad.sdk.utils.a;

import java.util.concurrent.Executor;

/* JADX INFO: loaded from: classes3.dex */
public final class f implements Executor {
    private Runnable bsA;
    private Runnable bsz;

    @Override // java.util.concurrent.Executor
    public final synchronized void execute(Runnable runnable) {
        if (this.bsz == null) {
            this.bsz = c(runnable);
            d.getExecutor().execute(this.bsz);
        } else {
            if (this.bsA == null) {
                this.bsA = c(runnable);
            }
        }
    }

    private Runnable c(final Runnable runnable) {
        return new Runnable() { // from class: com.kwad.sdk.utils.a.f.1
            @Override // java.lang.Runnable
            public final void run() {
                try {
                    runnable.run();
                } finally {
                    f.this.scheduleNext();
                }
            }
        };
    }

    /* JADX INFO: Access modifiers changed from: private */
    public synchronized void scheduleNext() {
        Runnable runnable = this.bsA;
        this.bsz = runnable;
        this.bsA = null;
        if (runnable != null) {
            d.getExecutor().execute(this.bsz);
        }
    }
}
