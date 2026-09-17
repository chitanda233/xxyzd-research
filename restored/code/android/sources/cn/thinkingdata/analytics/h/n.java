package cn.thinkingdata.analytics.h;

import cn.thinkingdata.core.utils.TimeUtil;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Locale;
import java.util.TimeZone;
import java.util.regex.Pattern;

/* JADX INFO: loaded from: classes.dex */
public class n implements e {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final TimeZone f123a;
    private final Date b;
    private boolean c = true;

    public n(Date date, TimeZone timeZone) {
        this.b = date == null ? new Date() : date;
        this.f123a = timeZone;
    }

    @Override // cn.thinkingdata.analytics.h.e
    public Double a() {
        if (!this.c || this.f123a == null) {
            return null;
        }
        return Double.valueOf(q.a(this.b.getTime(), this.f123a));
    }

    public void a(boolean z) {
    }

    @Override // cn.thinkingdata.analytics.h.e
    public String b() {
        try {
            SimpleDateFormat simpleDateFormat = new SimpleDateFormat(TimeUtil.TIME_PATTERN, Locale.CHINA);
            TimeZone timeZone = this.f123a;
            if (timeZone != null) {
                simpleDateFormat.setTimeZone(timeZone);
            }
            String str = simpleDateFormat.format(this.b);
            return !Pattern.compile("\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}\\.\\d{3}").matcher(str).find() ? q.a(this.b, this.f123a) : str;
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
    }

    public void c() {
        this.c = false;
    }
}
