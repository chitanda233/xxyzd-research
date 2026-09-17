package com.sigmob.sdk.base.models.config;

import android.os.Parcelable;
import com.czhj.wire.AndroidMessage;
import com.czhj.wire.FieldEncoding;
import com.czhj.wire.Message;
import com.czhj.wire.ProtoAdapter;
import com.czhj.wire.ProtoReader;
import com.czhj.wire.ProtoWriter;
import com.czhj.wire.WireField;
import com.czhj.wire.internal.Internal;
import com.czhj.wire.okio.ByteString;
import java.io.IOException;

/* JADX INFO: loaded from: classes3.dex */
public final class SigmobPreload extends AndroidMessage<SigmobPreload, Builder> {
    public static final ProtoAdapter<SigmobPreload> ADAPTER;
    public static final Parcelable.Creator<SigmobPreload> CREATOR;
    public static final String DEFAULT_P_ID = "";
    public static final String DEFAULT_P_MD5 = "";
    private static final long serialVersionUID = 0;

    @WireField(adapter = "com.squareup.wire.ProtoAdapter#STRING", tag = 1)
    public final String p_id;

    @WireField(adapter = "com.squareup.wire.ProtoAdapter#STRING", tag = 2)
    public final String p_md5;

    public static final class Builder extends Message.Builder<SigmobPreload, Builder> {
        public String p_id;
        public String p_md5;

        @Override // com.czhj.wire.Message.Builder
        public SigmobPreload build() {
            return new SigmobPreload(this.p_id, this.p_md5, super.buildUnknownFields());
        }

        public Builder p_id(String p_id) {
            this.p_id = p_id;
            return this;
        }

        public Builder p_md5(String p_md5) {
            this.p_md5 = p_md5;
            return this;
        }
    }

    private static final class ProtoAdapter_SigmobPreload extends ProtoAdapter<SigmobPreload> {
        public ProtoAdapter_SigmobPreload() {
            super(FieldEncoding.LENGTH_DELIMITED, SigmobPreload.class);
        }

        /* JADX WARN: Can't rename method to resolve collision */
        @Override // com.czhj.wire.ProtoAdapter
        public SigmobPreload decode(ProtoReader reader) throws IOException {
            Builder builder = new Builder();
            long jBeginMessage = reader.beginMessage();
            while (true) {
                int iNextTag = reader.nextTag();
                if (iNextTag == -1) {
                    reader.endMessage(jBeginMessage);
                    return builder.build();
                }
                if (iNextTag == 1) {
                    builder.p_id(ProtoAdapter.STRING.decode(reader));
                } else if (iNextTag != 2) {
                    FieldEncoding fieldEncodingPeekFieldEncoding = reader.peekFieldEncoding();
                    builder.addUnknownField(iNextTag, fieldEncodingPeekFieldEncoding, fieldEncodingPeekFieldEncoding.rawProtoAdapter().decode(reader));
                } else {
                    builder.p_md5(ProtoAdapter.STRING.decode(reader));
                }
            }
        }

        @Override // com.czhj.wire.ProtoAdapter
        public void encode(ProtoWriter writer, SigmobPreload value) throws IOException {
            ProtoAdapter.STRING.encodeWithTag(writer, 1, value.p_id);
            ProtoAdapter.STRING.encodeWithTag(writer, 2, value.p_md5);
            writer.writeBytes(value.unknownFields());
        }

        @Override // com.czhj.wire.ProtoAdapter
        public int encodedSize(SigmobPreload value) {
            return ProtoAdapter.STRING.encodedSizeWithTag(1, value.p_id) + ProtoAdapter.STRING.encodedSizeWithTag(2, value.p_md5) + value.unknownFields().size();
        }

        @Override // com.czhj.wire.ProtoAdapter
        public SigmobPreload redact(SigmobPreload value) {
            Builder builderNewBuilder = value.newBuilder();
            builderNewBuilder.clearUnknownFields();
            return builderNewBuilder.build();
        }
    }

    static {
        ProtoAdapter_SigmobPreload protoAdapter_SigmobPreload = new ProtoAdapter_SigmobPreload();
        ADAPTER = protoAdapter_SigmobPreload;
        CREATOR = AndroidMessage.newCreator(protoAdapter_SigmobPreload);
    }

    public SigmobPreload(String p_id, String p_md5) {
        this(p_id, p_md5, ByteString.EMPTY);
    }

    public SigmobPreload(String p_id, String p_md5, ByteString unknownFields) {
        super(ADAPTER, unknownFields);
        this.p_id = p_id;
        this.p_md5 = p_md5;
    }

    public boolean equals(Object other) {
        if (other == this) {
            return true;
        }
        if (!(other instanceof SigmobPreload)) {
            return false;
        }
        SigmobPreload sigmobPreload = (SigmobPreload) other;
        return unknownFields().equals(sigmobPreload.unknownFields()) && Internal.equals(this.p_id, sigmobPreload.p_id) && Internal.equals(this.p_md5, sigmobPreload.p_md5);
    }

    public int hashCode() {
        int i = this.hashCode;
        if (i != 0) {
            return i;
        }
        int iHashCode = unknownFields().hashCode() * 37;
        String str = this.p_id;
        int iHashCode2 = (iHashCode + (str != null ? str.hashCode() : 0)) * 37;
        String str2 = this.p_md5;
        int iHashCode3 = iHashCode2 + (str2 != null ? str2.hashCode() : 0);
        this.hashCode = iHashCode3;
        return iHashCode3;
    }

    @Override // com.czhj.wire.Message
    public Builder newBuilder() {
        Builder builder = new Builder();
        builder.p_id = this.p_id;
        builder.p_md5 = this.p_md5;
        builder.addUnknownFields(unknownFields());
        return builder;
    }

    @Override // com.czhj.wire.Message
    public String toString() {
        StringBuilder sb = new StringBuilder();
        if (this.p_id != null) {
            sb.append(", p_id=").append(this.p_id);
        }
        if (this.p_md5 != null) {
            sb.append(", p_md5=").append(this.p_md5);
        }
        return sb.replace(0, 2, "SigmobPreload{").append('}').toString();
    }
}
