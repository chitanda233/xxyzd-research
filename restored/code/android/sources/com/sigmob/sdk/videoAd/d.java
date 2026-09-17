package com.sigmob.sdk.videoAd;

import com.czhj.sdk.common.track.AdTracker;
import com.czhj.sdk.common.utils.Preconditions;
import java.io.Serializable;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Locale;

/* JADX INFO: loaded from: classes4.dex */
public class d extends AdTracker implements Serializable, Comparable<d> {
    private static final long serialVersionUID = 0;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final float f3634a;

    public d(final String event, float trackingFraction) {
        super(AdTracker.MessageType.QUARTILE_EVENT, null, event, null);
        Preconditions.NoThrow.checkArgument(trackingFraction >= 0.0f);
        this.f3634a = trackingFraction;
    }

    private float a() {
        return this.f3634a;
    }

    public static List<d> a(List<d> fractionalTrackers, String event, long currentPosition, long duration) {
        if (duration <= 0 || currentPosition < 0) {
            return Collections.emptyList();
        }
        ArrayList arrayList = new ArrayList();
        d dVar = new d(event, currentPosition / duration);
        int size = fractionalTrackers.size();
        for (int i = 0; i < size; i++) {
            d dVar2 = fractionalTrackers.get(i);
            if (dVar2.compareTo(dVar) > 0) {
                break;
            }
            if (!dVar2.isTracked()) {
                arrayList.add(dVar2);
            }
        }
        return arrayList;
    }

    @Override // java.lang.Comparable
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public int compareTo(final d other) {
        return Double.compare(a(), other.a());
    }

    public String toString() {
        return String.format(Locale.US, "%2f: %s", Float.valueOf(this.f3634a), getUrl());
    }
}
