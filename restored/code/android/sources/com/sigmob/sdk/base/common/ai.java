package com.sigmob.sdk.base.common;

import com.czhj.sdk.common.track.AdTracker;

/* JADX INFO: loaded from: classes3.dex */
public class ai extends AdTracker {
    public ai(String trackingUrl, String event, String requestId) {
        super(AdTracker.MessageType.TRACKING_URL, trackingUrl, event, requestId);
    }
}
