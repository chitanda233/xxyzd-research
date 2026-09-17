package com.czhj.wire.okio;

import android.support.v4.media.session.PlaybackStateCompat;

/* JADX INFO: loaded from: classes2.dex */
final class SegmentPool {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    static final long f2400a = 65536;
    static Segment b;
    static long c;

    private SegmentPool() {
    }

    static Segment a() {
        synchronized (SegmentPool.class) {
            Segment segment = b;
            if (segment == null) {
                return new Segment();
            }
            b = segment.h;
            segment.h = null;
            c -= PlaybackStateCompat.ACTION_PLAY_FROM_URI;
            return segment;
        }
    }

    static void a(Segment segment) {
        if (segment.h != null || segment.i != null) {
            throw new IllegalArgumentException();
        }
        if (segment.f) {
            return;
        }
        synchronized (SegmentPool.class) {
            long j = c;
            if (j + PlaybackStateCompat.ACTION_PLAY_FROM_URI > 65536) {
                return;
            }
            c = j + PlaybackStateCompat.ACTION_PLAY_FROM_URI;
            segment.h = b;
            segment.e = 0;
            segment.d = 0;
            b = segment;
        }
    }
}
