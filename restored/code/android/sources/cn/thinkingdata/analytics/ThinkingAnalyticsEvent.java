package cn.thinkingdata.analytics;

import cn.thinkingdata.analytics.h.k;
import java.util.Date;
import java.util.TimeZone;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public abstract class ThinkingAnalyticsEvent {
    private final String mEventName;
    private Date mEventTime;
    private final JSONObject mProperties;
    private TimeZone mTimeZone;

    ThinkingAnalyticsEvent(String str, JSONObject jSONObject) {
        this.mEventName = str;
        this.mProperties = jSONObject;
    }

    abstract k getDataType();

    String getEventName() {
        return this.mEventName;
    }

    Date getEventTime() {
        return this.mEventTime;
    }

    abstract String getExtraField();

    abstract String getExtraValue();

    JSONObject getProperties() {
        return this.mProperties;
    }

    TimeZone getTimeZone() {
        return this.mTimeZone;
    }

    public void setEventTime(Date date) {
        this.mEventTime = date;
    }

    public void setEventTime(Date date, TimeZone timeZone) {
        this.mEventTime = date;
        this.mTimeZone = timeZone;
    }
}
