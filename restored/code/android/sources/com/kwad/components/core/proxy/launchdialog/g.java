package com.kwad.components.core.proxy.launchdialog;

import androidx.lifecycle.Lifecycle;

/* JADX INFO: loaded from: classes3.dex */
public interface g {

    public static class b implements g {
        private Lifecycle.Event ajj;

        public b(Lifecycle.Event event) {
            this.ajj = event;
        }

        public final boolean b(Lifecycle.Event event) {
            return this.ajj.equals(event);
        }

        public final String toString() {
            return "PageEventItem{mEvent=" + this.ajj + '}';
        }
    }

    public static class a implements g {
        private long ajq;

        public a(long j) {
            this.ajq = j;
        }

        public final boolean N(long j) {
            return this.ajq > 0 && System.currentTimeMillis() - j >= this.ajq;
        }

        public final String toString() {
            return "DurationMoreThanItem{mDuration=" + this.ajq + '}';
        }
    }
}
