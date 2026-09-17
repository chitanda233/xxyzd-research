package com.sigmob.sdk.base.utils;

import android.os.SystemClock;
import android.view.MotionEvent;
import cn.thinkingdata.core.utils.TimeUtil;
import com.czhj.sdk.logger.SigmobLogger;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Locale;

/* JADX INFO: loaded from: classes3.dex */
public class u {
    public static Long[] a(String tag, MotionEvent event) {
        if (event == null) {
            return null;
        }
        long downTime = event.getDownTime();
        long eventTime = event.getEventTime();
        long jCurrentTimeMillis = System.currentTimeMillis() - SystemClock.uptimeMillis();
        long j = downTime + jCurrentTimeMillis;
        long j2 = eventTime + jCurrentTimeMillis;
        SimpleDateFormat simpleDateFormat = new SimpleDateFormat(TimeUtil.TIME_PATTERN, Locale.getDefault());
        SigmobLogger.d(tag, "convertAndLogMotionEventTimes: downTimeAbsolute = " + j + ", downTimeFormatted = " + simpleDateFormat.format(new Date(j)) + ", eventTimeAbsolute = " + j2 + ", eventTimeFormatted = " + simpleDateFormat.format(new Date(j2)), new Object[0]);
        return new Long[]{Long.valueOf(j), Long.valueOf(j2)};
    }
}
