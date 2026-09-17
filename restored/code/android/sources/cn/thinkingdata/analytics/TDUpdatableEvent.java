package cn.thinkingdata.analytics;

import cn.thinkingdata.analytics.h.k;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class TDUpdatableEvent extends TDEventModel {
    private final String mEventId;

    public TDUpdatableEvent(String str, JSONObject jSONObject, String str2) {
        super(str, jSONObject);
        this.mEventId = str2;
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsEvent
    k getDataType() {
        return k.TRACK_UPDATE;
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsEvent
    String getExtraField() {
        return "#event_id";
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsEvent
    String getExtraValue() {
        return this.mEventId;
    }
}
